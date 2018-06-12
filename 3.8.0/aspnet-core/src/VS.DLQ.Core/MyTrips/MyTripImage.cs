using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;

namespace VS.DLQ.MyTrips
{    
   [Table("DLQMyTripImages")]
    public class MyTripImage : Entity<long>
    {
        [ForeignKey("MyTripId")]
        public virtual MyTrip MyTrips { get; protected set; }
        public virtual long MyTripId { get; protected set; }           
                
        public byte[] Image { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
