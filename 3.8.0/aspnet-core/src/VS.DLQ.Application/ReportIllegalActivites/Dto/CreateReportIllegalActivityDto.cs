using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using VS.DLQ.Engagement;

namespace VS.DLQ.ReportIllegalActivites.Dto
{
    [AutoMapTo(typeof(ReportIllegalActivity))]
    public class CreateReportIllegalActivityDto
    {
        public virtual long UserId { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public string UserName { get; set; }

        [Required]
        public string VesselNo { get; set; }

        public DateTime IllegalActivityDate { get; set; }

        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
