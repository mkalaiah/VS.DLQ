using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace VS.DLQ.Fish
{
    [Table("DLQSpecies")]
    public class Species : Entity
    {  
        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public virtual string Description { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxURLLength)]
        public virtual string URL { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}
