using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrapoDeeds.Models
{
    public class Tasks
    {
        [Key]
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
        [Display(Name = "Start Date")]
        public DateTime startDate
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
        [ForeignKey("Cases")]
        [Display(Name = "Case ID")]
        public int CaseID
        {
            get;
            set;
        }
    }
}
