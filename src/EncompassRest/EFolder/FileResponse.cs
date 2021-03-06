using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.EFolder
{
    /// <summary>
    /// Object containing information about the file generated by the export job.
    /// </summary>
    public sealed class FileResponse : EntityReference
    {
        /// <summary>
        /// The Authorization request header to be passed to download the export job file.
        /// </summary>
        public string? AuthorizationHeader { get; set; }

        /// <summary>
        /// Content type of the export file. Currently, the only format supported is PDF. The value returned would be application/pdf.
        /// </summary>
        public string? ContentType { get; set; }

        /// <summary>
        /// The size of the attachment in bytes.
        /// </summary>
        public int? FileSize { get; set; }

        /// <summary>
        /// Number of pages the file contains.
        /// </summary>
        public int? PageCount { get; set; }

        /// <summary>
        /// FileResponse constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public FileResponse(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// FileResponse constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public FileResponse(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// FileResponse deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public FileResponse()
        {
        }
    }
}
