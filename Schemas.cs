﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
using EncompassRest.HelperClasses;
using EncompassRest.JsonHelpers;
using Newtonsoft.Json.Linq;

namespace EncompassRest
{
    public sealed class Schemas
    {
        private const string _apiPath = "encompass/v1/schema";

        public EncompassRestClient Client { get; }

        internal Schemas(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<string> GetSchemaAsync() => GetSchemaAsync(null, false);

        public async Task<string> GetSchemaAsync(IEnumerable<string> entities, bool includeFieldExtensions)
        {
            var rp = new RequestParameters();
            if (entities?.Any() == true)
            {
                rp.Add("entities", string.Join(",", entities));
            }
            rp.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/loan{rp}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetSchemaAsync), response);
                }
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> GetSchemaFieldAsync(string fieldId)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/loan/{fieldId}");
            //var response = await _Session.RESTClient.GetAsync(API_PATH + "/loan/" + FieldID);
            var response = await Client.HttpClient.SendAsync(message);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RestException(nameof(GetSchemaFieldAsync), response);
            }
        }

        public async Task<string> GetFieldPathAsync(string fieldId)
        {
            string schemaJson;
            var returnPath = new StringBuilder();
            try
            {
                schemaJson = await GetSchemaFieldAsync(fieldId);
            }
            catch (RestException re)
            {
                throw new RestException("GetSchemaFieldAsync", re.Response);
            }

            var jsonMain = JObject.Parse(schemaJson);
            var entityTypes = jsonMain["entity_types"];
            foreach (var token in entityTypes)
            {
                var p = (JProperty)token;
                returnPath.Append(p.Name + ".");
            }

            //jsonMain["entity_types"].Last["properties"]
            
            var fieldIdTokens = jsonMain.FindTokens("field_id");
            if (fieldIdTokens.Count == 1)
            {
                var path = fieldIdTokens.FirstOrDefault().Path;
                var itemsInPath = path.Split('.');
                returnPath.Append(itemsInPath.GetValue(itemsInPath.Count() - 2));
            }
            else
            {
                var fieldInstanceTokens = jsonMain.FindTokens("field_instances");
                var path = fieldInstanceTokens.FirstOrDefault().Path;
                var itemsInPath = path.Split('.');
                returnPath.Append(itemsInPath.GetValue(itemsInPath.Count() - 2));
            }

            return returnPath.ToString();
        }

        public async Task GenerateClassFilesFromSchemaAsync(string destinationPath, string @namespace)
        {
            var supportedEntities = await Client.Loans.GetSupportedEntitiesAsync();
            var exceptions = new List<Exception>();
            var badEntities = new HashSet<string> { "LOCompensation", "VirtualFields", "CustomModelFields" };
            foreach (var entity in supportedEntities)
            {
                if (badEntities.Contains(entity))
                {
                    continue;
                }
                try
                {
                    var rawSchema = await GetSchemaAsync(new[] { entity }, true);

                    var jo = JToken.Parse(rawSchema);
                    var entities = jo["entity_types"];
                    foreach (var jt in entities.Children())
                        await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, ((JProperty)jt).Name, jo);
                }
                catch (Exception ex)
                {
                    exceptions.Add(new Exception(entity, ex));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        private async Task GenerateClassFileFromSchemaAsync(string destinationPath, string @namespace, string section, JToken schemaToken)
        {
            var sb = new StringBuilder();
            sb.Append(
$@"using System;
using System.Collections.Generic;

namespace {@namespace}
{{
    public sealed {(section == "Loan" ? "partial " : "")}class {section}
    {{
");
            var sectionProperties = schemaToken["entity_types"][section]["properties"];
            foreach (JProperty propertyToken in sectionProperties.Children())
            {
                var vName = propertyToken.Name;
                vName = vName.Substring(0, 1).ToUpper() + vName.Substring(1);

                var propertyType = GetPropertyType(propertyToken.Value);
                sb.AppendLine($"        public {propertyType} {vName} {{ get; set; }}");
            }

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, section + ".cs")))
            {
                await sw.WriteAsync(sb.ToString());
            }
        }

        private string GetPropertyType(JToken propertyTokenValue)
        {
            var vType = propertyTokenValue["type"].ToString();
            string entity;
            switch (vType)
            {
                case "string":
                case "uuid":
                    return "string";
                case "decimal":
                case "NA<decimal>":
                    return "decimal?";
                case "bool":
                case "int":
                    return $"{vType}?";
                case "date":
                case "datetime":
                    return "DateTime?";
                case "set":
                case "list":
                    entity = propertyTokenValue["element_type"].ToString();
                    entity = entity.Substring(0, 1).ToUpper() + entity.Substring(1);
                    return $"List<{entity}>";
                case "entity":
                    entity = propertyTokenValue["entity_type"].ToString();
                    entity = entity.Substring(0, 1).ToUpper() + entity.Substring(1);
                    return entity;
                default:
                    return $"PROBLEM<{vType}>";
            }
        }
    }
}
