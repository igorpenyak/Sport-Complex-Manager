using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Entities
{
    public class SportsHall
    {
        public int Id { get; set; }
        public SportsHallType Type { get; set; }
        public int Area { get; set; }
        public decimal Rate { get; set; }
        public int Status { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] Type: {1}, Area: {2}, Rate: {3}", Id, Type.Name, Area, Rate);
        }
    }
}
