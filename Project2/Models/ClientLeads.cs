using System;
using System.ComponentModel.DataAnnotations;

namespace CrapoDeeds.Models
{
    public class ClientLeads
    {
        public int clientLeadID
        {
            get;
            set;
        }
        [Display(Name = "Name")]
        public string clientLeadName
        {
            get;
            set;
        }
        [Display(Name = "Email")]
        public string clientLeadEmail
        {
            get;
            set;
        }
        [Display(Name = "Phone Number")]
        public string clientLeadPhoneNumber
        {
            get;
            set;
        }
    }
}
