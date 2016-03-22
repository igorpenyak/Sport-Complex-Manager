using SportsComplex.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Repositories
{
    interface IRentersRepository
    {
        IEnumerable<Renter> SelectAll();
        Renter GetRenterById(int renterId);
    }
}
