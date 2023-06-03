using System.ComponentModel.DataAnnotations.Schema;

namespace DemoParking.Models
{
    [Table("Payment")]
    public class Payment : Common
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int EmployeeId { get; set; }
        public bool isTicketMonth { get; set; }
        public Employee Employee { get; set; }
    }
}
