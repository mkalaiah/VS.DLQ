using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace VS.DLQ.Species
{
    [AutoMapTo(typeof(Fish.Species))]
    public class SpeciesDto : EntityDto
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
