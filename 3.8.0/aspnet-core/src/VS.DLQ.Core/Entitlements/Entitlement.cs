using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace VS.DLQ.Entitlements
{
    [Table("DLQEntitlements")]
    public class Entitlement : Entity<long>
    {
        [Required]
        [MaxLength(DLQConsts.MaxEntitlementNameLength)]
        public string EntitlementName { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public Entitlement()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
