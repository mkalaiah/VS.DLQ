using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.Engagement
{
    [Table("DLQReportIssues")]
    public class ReportIssue : Entity<long>
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public string UserName { get; set; }

        [Required]
        public string IssueDescription { get; set; }
        
        public DateTime TimeStamp { get; set; }
    }
}
