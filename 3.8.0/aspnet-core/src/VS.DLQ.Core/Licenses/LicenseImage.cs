using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
<<<<<<< HEAD
using VS.DLQ.Licenses;

namespace VS.DLQ.LicenseImages
=======

namespace VS.DLQ.Licenses
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
{
    [Table("DLQLicenseImages")]
    public class LicenseImage : Entity
    {
        [ForeignKey("LicenseId")]
        public virtual License License { get; protected set; }
        public virtual long LicenseId { get; protected set; }

        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public byte[] Name { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}

