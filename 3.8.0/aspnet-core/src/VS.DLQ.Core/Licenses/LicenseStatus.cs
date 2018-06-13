using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

<<<<<<< HEAD
namespace VS.DLQ.LicenseStatuses
=======
namespace VS.DLQ.Licenses
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
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
