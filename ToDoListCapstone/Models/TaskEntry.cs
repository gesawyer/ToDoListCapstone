using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListCapstone.Models
{
    public class TaskEntry
    {
        public int EmployeeId { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        
        public bool Status { get; set; }
    }
}
