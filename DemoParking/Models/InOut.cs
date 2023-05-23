using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoParking.Models
{
    [Table("InOut")]
    public class InOut : Common
    {
        public int Id { get; set; }
        public string Code { get; set; } // mã xe
        public DateTime DateIn { get; set; } // ngày gửi
        public DateTime? DateOut { get; set; } // ngảy trả
        public bool IsTicket { get; set; } // là vé tháng?
        public Status Status { get; set; } // đang giữ hoặc không
        public TypeTicket TypeTicket { get; set; }// loai xe
        public int EmployeeId { get; set; } // nhân viên tạo
        public Employee Employee { get; set; }
    }
}
