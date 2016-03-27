using SportsComplex.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Repositories
{
    interface ICustomersRepository
    {
        IEnumerable<Customer> SelectAll();

        Customer GetById(int renterId);

        int Add(string lastName, string firstName, string phone);

        void Edit(int renterId, string lastName, string firstName, string phone);

        void Remove(int renterId); 
    }
}
