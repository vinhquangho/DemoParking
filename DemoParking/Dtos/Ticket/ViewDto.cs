using System;

namespace DemoParking.Dtos.Ticket
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string TypeTicket { get; set; }
        public string Status { get; set; }
        public string EmployeeName { get; set; }
    }
}
