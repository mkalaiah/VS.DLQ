using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace VS.DLQ.SocialStatuses
{
    [Table("DLQSocialStatuses")]
    public class SocialStatus : Entity<long>
    {
        [Required]
        public string Status { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
