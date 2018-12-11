using System;
using System.ComponentModel.DataAnnotations;

namespace CrapoDeeds.Models
{
    public class Client
    {
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
        [Display(Name = "Client Address")]
        public string companyAddress
        {
            get;
            set;
        }
       
    }
}
