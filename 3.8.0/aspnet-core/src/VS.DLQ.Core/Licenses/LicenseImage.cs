using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Licenses;

namespace VS.DLQ.Licenses
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

