using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParking.Models
{
    public class Issue: Common
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Reason { get; set; }
        public string Content { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
