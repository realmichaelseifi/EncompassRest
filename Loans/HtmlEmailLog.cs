using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class HtmlEmailLog
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public string Body { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public string Creator { get; set; }
        public DateTime? DateUtc { get; set; }
        public string Description { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public string Guid { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string SystemId { get; set; }
    }
}