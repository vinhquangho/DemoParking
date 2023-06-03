using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParking.Dtos.Payment
{
    public class ViewDto
    {
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string EmployeeName { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsTicketMonth { get; set; }
    }
}
