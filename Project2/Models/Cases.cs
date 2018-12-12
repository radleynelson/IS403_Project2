﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrapoDeeds.Models
{
    [Table("Cases")]
    public class Cases
    {
        [Key]
        public int caseID
        {
            get;
            set;
        }
        [Display(Name = "Case Name")]
        public string caseName
        {
            get;
            set;
        }

        [ForeignKey("Clients")]
        public virtual Clients Client { get; set; }

        [ForeignKey("taskID")]
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
