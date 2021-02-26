using System;
using System.Collections.Generic;

namespace ToDoListCapstone.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public string TaskName { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? Completed { get; set; }
    }
}
