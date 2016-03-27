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

        IEnumerable<SportsHall> GetSportsHallsByFilter(SportsHallType sportstHallType, int minArea, int maxArea, decimal minRate, decimal maxRate);

        int Add(int hallTypeId, int area, decimal rate);

        void Remove(int id);
    }
}
