using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsComplex.Entities;
using System.Data.SqlClient;
using System.Data;

namespace SportsComplex.Repositories
{
    public class SqlSportsHallTypesRepository : SqlBaseRepository, ISportsHallTypes
    {
        public SqlSportsHallTypesRepository(string connnectionStr)
        {
            ConnectionString = connnectionStr;
        }

        public IEnumerable<SportsHallType> SelectAll()
        {
            var hallsTypes = new List<SportsHallType>();

            // Get data from database.
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM tblClassType";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sportsHall = new SportsHallType()
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"]
                            };

                            hallsTypes.Add(sportsHall);
                        }
                    }
                }
            }

            return hallsTypes;
        }
    }
}
