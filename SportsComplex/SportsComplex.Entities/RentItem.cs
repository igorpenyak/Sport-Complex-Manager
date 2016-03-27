using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Entities
{
    public class RentItem
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public SportsHall SportsHall { get; set; } 
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Cost { get; set; }
        public bool Deleted { get; set; }
    }
}
