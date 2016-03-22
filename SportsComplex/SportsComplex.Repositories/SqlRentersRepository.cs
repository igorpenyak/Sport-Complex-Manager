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
    public class SqlRentersRepository : SqlBaseRepository, IRentersRepository
    {
        public SqlRentersRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public Renter GetRenterById(int renterId)
        {
            Renter renterRes = new Renter();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"SELECT Id, LastName, FirstName, Phone
                                            FROM tblRenter
                                            WHERE Id = @rentId";
                    command.Parameters.AddWithValue("@rentId", renterId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var renter = new Renter()
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Phone = (string)reader["Phone"]
                            };

                            renterRes = renter;
                            break;
                        }
                    }
                }
            }

            return renterRes;
        }

        public IEnumerable<Renter> SelectAll()
        {
            var renters = new List<Renter>();

            // Get data from database.
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"SELECT Id, LastName, FirstName, Phone
                                            FROM tblRenter";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var renter = new Renter()
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Phone = (string)reader["Phone"]
                            };

                            renters.Add(renter);
                        }
                    }
                }
            }

            return renters;
        }
    }
}
