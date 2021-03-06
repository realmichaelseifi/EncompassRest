using System.Runtime.Serialization;

namespace EncompassRest.Webhook
{
    /// <summary>
    /// WebhookResourceType
    /// </summary>
    public enum WebhookResourceType
    {
        /// <summary>
        /// loan
        /// </summary>
        [EnumMember(Value = "loan")]
        Loan = 0,
        /// <summary>
        /// Transaction
        /// </summary>
        Transaction = 1,
        /// <summary>
        /// TaskGroup
        /// </summary>
        TaskGroup = 2,
        /// <summary>
        /// EnhancedConditionTemplate
        /// </summary>
        EnhancedConditionTemplate = 3,
        /// <summary>
        /// Task
        /// </summary>
        Task = 4,
        /// <summary>
        /// EnhancedConditionType
        /// </summary>
        EnhancedConditionType = 5,
        /// <summary>
        /// SubTask
        /// </summary>
        SubTask = 6,
        /// <summary>
        /// ExternalOrganization
        /// </summary>
        ExternalOrganization = 7,
        /// <summary>
        /// Trade
        /// </summary>
        Trade = 8,
        /// <summary>
        /// ServiceOrder
        /// </summary>
        ServiceOrder = 9,
        /// <summary>
        /// DocumentOrder
        /// </summary>
        DocumentOrder = 10
    }
}