using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrapoDeeds.Models
{
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
        [ForeignKey("Cases")]
        public int? caseID { get; set; }
        public virtual ICollection<Cases> cases { get; set; }
    }
}
