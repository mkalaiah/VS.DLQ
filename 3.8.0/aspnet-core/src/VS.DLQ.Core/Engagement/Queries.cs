using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.Engagement
{
    [Table("DLQQueries")]
    public class Query : Entity
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }      

        [Required]
        public virtual string UserName { get; set; }

        [Required]
        public virtual string EmailId { get; set; }

        [Required]
        public virtual string Question { get; set; }

        public virtual DateTime TimeStamp { get; set; }

        public virtual bool IsReplied { get; set; }

        public virtual string Response { get; set; }

        public virtual DateTime ResponseTimeStamp { get; set; }
    }
}
