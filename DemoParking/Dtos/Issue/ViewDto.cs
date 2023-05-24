using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParking.Dtos.Issue
{
    public class ViewDto
    {
        public string Code { get;set; }
        public string Reason { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public string EmployeeName { get; set; }
    }
}
