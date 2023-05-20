using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoParking.Models
{
    [Table("Ticket")]
    public class Ticket : Common
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; } // mã xe
        public string Name { get; set; } // tên xe
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public TypeTicket TypeTicket { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
    public enum TypeTicket
    {
        [Display(Name = "Xe Đạp")]
        Ticket1 = 1, // xe dap
        [Display(Name = "2 bánh")]
        Ticket2 = 2, // 2 banh
        [Display(Name = "4 bánh")]
        Ticket3 = 3, // 4 cho
        [Display(Name = "8 bánh")]
        Ticket4 = 4, // 8 cho
        [Display(Name = "16 bánh")]
        Ticket5 = 5, // 16 cho
    }
}
