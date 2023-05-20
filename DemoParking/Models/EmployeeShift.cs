using System.ComponentModel.DataAnnotations;

namespace DemoParking.Models
{
    public class EmployeeShift : Common
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}
