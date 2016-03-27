using SportsComplex.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsComplex.Repositories
{
    interface IUsersRepository
    {
        IEnumerable<User> SelectAll();
        
        // Returns user's ID if success.
        int Auth(string Login, string Password);
    }
}
