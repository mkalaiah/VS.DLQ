using System;

namespace DLQMobileApp.Models
{
    public class CreateReportIssueDto
    {
        public virtual long UserId { get; set; }

        public string UserName { get; set; }

        public string IssueDescription { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
