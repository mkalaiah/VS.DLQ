using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.Engagement
{
    [Table("DLQReportIllegalActivities")]
    public class ReportIllegalActivity : Entity<long>
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

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
