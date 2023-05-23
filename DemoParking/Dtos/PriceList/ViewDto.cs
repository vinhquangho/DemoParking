using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParking.Dtos.PriceList
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string HourStart { get; set; }
        public string HourEnd { get; set; }
        public decimal Price { get; set; }
        public string TypeTicket { get; set; }
    }
}
