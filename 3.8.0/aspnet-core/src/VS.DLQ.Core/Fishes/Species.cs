<<<<<<< HEAD
﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
=======
﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d

namespace VS.DLQ.Fish
{
    [Table("DLQSpecies")]
    public class Species : Entity
<<<<<<< HEAD
    {  
        [Required]
        [MaxLength(DLQConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxDescriptionLength)]
        public virtual string Description { get; set; }

        [Required]
        [MaxLength(DLQConsts.MaxURLLength)]
=======
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
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
        public virtual string URL { get; set; }

        public virtual DateTime TimeStamp { get; set; }
    }
}
