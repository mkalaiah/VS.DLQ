using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;
using VS.DLQ.Engagement;

namespace VS.DLQ.Queries.Dto
{
    [AutoMapTo(typeof(Query))]
    public class CreateQueryDto
    {
        public virtual long UserId { get; set; }

        [Required]
        public virtual string UserName { get; set; }

        [Required]
        [EmailAddress]
        public virtual string EmailId { get; set; }

        [Required]
        public virtual string Question { get; set; }
        public virtual DateTime TimeStamp { get; set; }

        public virtual bool IsReplied { get; set; }

        public virtual string Response { get; set; }

        public virtual DateTime ResponseTimeStamp { get; set; }

        public CreateQueryDto()
        {
            TimeStamp = DateTime.Now;
        }
    }
}

