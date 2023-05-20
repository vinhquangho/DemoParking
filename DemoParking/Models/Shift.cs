using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoParking.Models
{
    public class Shift : Common
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HourStart { get; set; }
        public DateTime HourEnd { get; set;}
        public decimal Price { get; set; }
        public List<EmployeeShift> EmployeeShifts { get; set; }
    }
}
