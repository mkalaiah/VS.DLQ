using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;
using VS.DLQ.Engagement;

namespace VS.DLQ.ReportIssues.Dto
{
    [AutoMapTo(typeof(ReportIssue))]
    public class ReportIssueDto : EntityDto<long>
    {
        public virtual long UserId { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string IssueDescription { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
