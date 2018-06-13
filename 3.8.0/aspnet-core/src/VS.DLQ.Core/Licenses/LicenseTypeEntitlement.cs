using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Entitlements;
<<<<<<< HEAD
using VS.DLQ.LicenseTypes;

namespace VS.DLQ.LicenseTypeEntitlements
=======

namespace VS.DLQ.Licenses
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
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
