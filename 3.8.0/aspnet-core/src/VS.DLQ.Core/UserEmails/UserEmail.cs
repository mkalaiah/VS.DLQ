using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.UserEmails
{
    [Table("DLQUserEmails")]
    public class UserEmail : Entity<long>
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

        public string Email { get; set; }
    }
}
