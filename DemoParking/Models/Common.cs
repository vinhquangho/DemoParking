using System;

namespace DemoParking.Models
{
    public class Common
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
