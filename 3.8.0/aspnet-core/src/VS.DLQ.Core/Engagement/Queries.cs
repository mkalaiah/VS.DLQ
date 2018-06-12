using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VS.DLQ.Engagement
{
    [Table("DLQQueries")]
    public class Query : Entity
    {
        [ForeignKey("Users")]
        public virtual int UserId { get; set; }

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
