using System;

namespace DLQMobileApp.Models
{
    public class CreateQueryDto
    {
        public virtual long UserId { get; set; }

        public virtual string UserName { get; set; }

        public virtual string EmailId { get; set; }

        public virtual string Question { get; set; }

        public virtual DateTime TimeStamp { get; set; }

        public virtual bool IsReplied { get; set; }

        public virtual string Response { get; set; }

        public virtual DateTime ResponseTimeStamp { get; set; }
    }
}

