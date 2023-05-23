using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParking.Models
{
    [Table("PriceList")]
    public class PriceList : Common
    {
        public int Id { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public decimal Price { get; set; }
        public TypeTicket TypeTicket { get; set; }
    }
}
