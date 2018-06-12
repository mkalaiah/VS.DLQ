using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.MyTrips
{    
   [Table("DLQMyTrips")]
    public class MyTrip : Entity<long>
    {
        [ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        public virtual long UserId { get; protected set; }

        [Required]
        public DateTime TripDate { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public string Title { get; set; }
                
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
