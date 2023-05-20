using System;

namespace DemoParking.Dtos.InOut
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string Status { get; set; }
        public string EmployeeName { get; set; }
    }
}
