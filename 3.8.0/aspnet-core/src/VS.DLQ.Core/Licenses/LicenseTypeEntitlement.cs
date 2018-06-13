using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Entitlements;

namespace VS.DLQ.Licenses
{
    [Table("DLQLicenseTypeEntitlements")]
    public class LicenseTypeEntitlement : Entity
    {
        [ForeignKey("LicenseTypeId")]
        public virtual LicenseType Licensetype { get; protected set; }
        public virtual long LicenseTypeId { get; protected set; }

        [ForeignKey("EntitlementId")]
        public virtual Entitlement Entitlement { get; protected set; }
        public virtual long EntitlementId { get; protected set; }

        public DateTime TimeStamp { get; set; }

        public LicenseTypeEntitlement()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
