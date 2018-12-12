using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrapoDeeds.Models
{
    [Table("Clients")]
    public class Clients
    {
        [Key]
        public int clientID
        {
            get;
            set;
        }
        [Display(Name = "Client Name")]
        public string clientName
        {
            get;
            set;
        }
        [Display(Name = "Client HQ Address")]
        public string clientHQAddress
        {
            get;
            set;
        }
        [Display(Name = "Client Email")]
        public string clientEmail
        {
            get;
            set;
        }
        [Display(Name = "Client Web Address")]
        public string clientWebAddress
        {
            get;
            set;
        }

        [ForeignKey("caseID")]
        public virtual ICollection<Cases> Cases { get; set; }
    }
}
