using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrapoDeeds.Models
{
    public class Cases
    {
        [Key]
        public int caseID
        {
            get;
            set;
        }
        [ForeignKey("Clients")]
        [Display(Name = "Client ID")]
        public int clientID
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
        [ForeignKey("Tasks")]
        public int? taskID { get; set; }
        public virtual ICollection<Tasks> tasks { get; set; }

    }
}
