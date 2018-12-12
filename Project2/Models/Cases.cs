using System;
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
        public virtual int clientID
        {
            get;
            set;
        }

        public virtual Clients Client { get; set; }
        
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
