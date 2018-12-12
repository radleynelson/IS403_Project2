using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrapoDeeds.Models
{
    [Table("Tasks")]
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
        
        public virtual int caseID
        {
            get;
            set;
        }

        public virtual Cases Case { get; set; }
    }
}
