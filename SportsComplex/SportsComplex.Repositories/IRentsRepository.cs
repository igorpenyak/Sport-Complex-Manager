using SportsComplex.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Repositories
{
    interface IRentsRepository
    {
        IEnumerable<RentItem> SelectAll();

        IEnumerable<RentItem> GetRentsOnDate(DateTime inputDate);

        IEnumerable<RentItem> GetRentsByRenterId(int renterId);

        int MakeRent(int renterId, int sportsHallId, DateTime dateStart, DateTime dateEnd, decimal Cost);

        // Returns money change
        decimal Remove(int rentId);
    }
}
