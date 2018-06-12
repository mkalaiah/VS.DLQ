using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VS.DLQ.Fish
{
    [Table("DLQSpecies")]
    public class Species : Entity
    {
        public const int MaxNameLength = 64;
        public const int MaxDescriptionLength = 100;
        public const int MaxURLLength = 100;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public virtual string Description { get; set; }

        [Required]
        [MaxLength(MaxURLLength)]
        public virtual string URL { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}
