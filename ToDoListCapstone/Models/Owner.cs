using System;
using System.Collections.Generic;

namespace ToDoListCapstone.Models
{
    public partial class Owner
    {
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerName { get; set; }
    }
}
