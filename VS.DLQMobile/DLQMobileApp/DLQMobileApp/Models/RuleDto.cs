using System;

namespace DLQMobileApp.Models
{
    public class RuleDto
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual string URL { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}
