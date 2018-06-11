using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;
using VS.DLQ.Licenses;

namespace VS.DLQ.UserLicenses
{
    [Table("DLQUserLicenses")]
    public class UserLicense : Entity
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

        [ForeignKey("LicenseId")]
        public virtual License License { get; protected set; }
        public virtual long LicenseId { get; protected set; }

        public DateTime TimeStamp { get; set; }
    }
}
