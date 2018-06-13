<<<<<<< HEAD
﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using VS.DLQ.Authorization.Users;
=======
﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d

namespace VS.DLQ.Engagement
{
    [Table("DLQQueries")]
    public class Query : Entity
<<<<<<< HEAD
    {   
        public virtual long UserId { get; protected set; }      

        [Required]
        [StringLength(DLQConsts.MaxNameLength)]
=======
    {
        [ForeignKey("Users")]
        public virtual int UserId { get; set; }

        [Required]
>>>>>>> 8f91001433374c7ef36ddc6903d0ebd71189008d
        public virtual string UserName { get; set; }

        [Required]
        public virtual string EmailId { get; set; }

        [Required]
        public virtual string Question { get; set; }

        public virtual DateTime TimeStamp { get; set; }

        public virtual bool IsReplied { get; set; }

        public virtual string Response { get; set; }

        public virtual DateTime ResponseTimeStamp { get; set; }
    }
}
