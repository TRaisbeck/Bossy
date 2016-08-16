using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bossy.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Category { get; set; }
        public string TaskDesc { get; set; }
        public string Note { get; set; }
        public bool Billable { get; set; }
        public int EstTime { get; set; }
        public int ActTIme { get; set; }
        public string Group { get; set; }
        public string Status { get; set; }
    }
}
