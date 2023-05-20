using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoParking.Models
{
    [Table("Employee")]
    public class Employee : Common
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Status Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public List<EmployeeShift> EmployeeShifts { get; set; }
    }
    public enum Status : short
    {
        Active = 1,
        DeActive = 2,
    }
}
