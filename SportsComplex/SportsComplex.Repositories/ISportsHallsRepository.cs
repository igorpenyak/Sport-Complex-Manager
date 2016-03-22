using SportsComplex.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Repositories
{
    interface ISportsHallsRepository
    {
        IEnumerable<SportsHall> SelectAll();
        IEnumerable<SportsHall> GetFreeSportsHalls();
        IEnumerable<SportsHall> GetFreeSportsHallsByFilter(SportsHallType sportstHallType, int minArea, int maxArea, decimal minRate, decimal maxRate);
    }
}
