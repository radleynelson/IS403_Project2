using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrapoDeeds.Models
{
    public class Case
    {
        public int caseID
        {
            get;
            set;
        }
        [Display(Name = "Client")]
        public Client client
        {
            get;
            set;
        }
        [Display(Name = "Case Description")]
        public string caseDescription
        {
            get;
            set;
        }
        public List<Task> tasks = new List<Task>();


    }
}
