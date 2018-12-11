using System;
using System.ComponentModel.DataAnnotations;

namespace CrapoDeeds.Models
{
    public class Task
    {
       public int taskID
        {
            get;
            set;
        }
        [Display(Name = "Task Owner Name")]
        public string taskOwner
        {
            get;
            set;
        }
        [Display(Name = "Task Description")]
        public string taskDescription
        {
            get;
            set;
        }
        [Display(Name = "Created Date")]
        public DateTime createdDate
        {
            get;
            set;
        }
        [Display(Name = "Due Date")]
        public DateTime dueDate
        {
            get;
            set;
        }
        [Display(Name = "Case")]
        public string Case
        {
            get;
            set;
        }
    }
}
