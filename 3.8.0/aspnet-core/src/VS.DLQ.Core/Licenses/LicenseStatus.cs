using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace VS.DLQ.LicenseStatuses
{
    [Table("DLQLicenseStatuses")]
    public class LicenseStatus : Entity<long>
    {
        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public LicenseStatus()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
