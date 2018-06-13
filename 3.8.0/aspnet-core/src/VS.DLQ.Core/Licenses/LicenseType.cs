using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

<<<<<<< HEAD
namespace VS.DLQ.LicenseTypes
=======
namespace VS.DLQ.Licenses
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
{
    [Table("DLQLicenseTypes")]
    public class LicenseType : Entity<long>
    {
        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public LicenseType()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
