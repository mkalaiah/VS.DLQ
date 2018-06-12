using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.UserProfiles
{
    [Table("DLQUserProfiles")]
    public class UserProfile : Entity<long>
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

        public DateTime DateOfBirth { get; set; }
        public string SocialStatus { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
