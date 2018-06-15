using System;

namespace DLQMobileApp.Models
{
    public class SpeciesDto
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual string URL { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}
