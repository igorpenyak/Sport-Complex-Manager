using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsComplex.Repositories
{
    public abstract class SqlBaseRepository
    {
        protected string ConnectionString { get; set; }
    }
}
