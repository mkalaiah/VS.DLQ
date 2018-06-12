using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.UserAddresses
{
    [Table("DLQUserAddresses")]
    public class UserAddress : Entity<long>
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

        public long UnitNumber { get; set; }
        public string StreetNumberAndName { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public long PostCode { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsCorrespondence { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
