using System;

namespace DLQMobileApp.Models
{
    public class CreateReportIllegalActivityDto
    {
        public virtual long UserId { get; set; }

        public string UserName { get; set; }

        public string VesselNo { get; set; }

        public DateTime IllegalActivityDate { get; set; }

        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
