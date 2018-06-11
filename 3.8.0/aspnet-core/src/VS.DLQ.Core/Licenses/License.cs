using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.LicenseStatuses;
using VS.DLQ.LicenseTypes;

namespace VS.DLQ.Licenses
{
    [Table("DLQLicenses")]
    public class License : Entity<long>
    {
        [ForeignKey("LicenseTypeId")]
        public virtual LicenseType Licensetype { get; protected set; }
        public virtual long LicenseTypeId { get; protected set; }

        [ForeignKey("LicenseStatusId")]
        public virtual LicenseStatus Licensestatus { get; protected set; }
        public virtual long LicenseStatusId { get; protected set; }

        public string LicenseNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ValidTill { get; set; }
        public string Version { get; set; }
        public string SubVersion { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
