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

        public int Add(string lastName, string firstName, string phone)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spAddRenter";

                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.Add(new SqlParameter("@renterId",
                                                        SqlDbType.Int,
                                                        0,
                                                        ParameterDirection.Output,
                                                        false,
                                                        0,
                                                        0,
                                                        "tblRenter",
                                                        DataRowVersion.Default,
                                                        null));
                    command.ExecuteNonQuery();

                    int renterId = (int)command.Parameters["@renterId"].Value;

                    return renterId;
                }
            }
        }

        public void Edit(int renterId, string lastName, string firstName, string phone)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"UPDATE tblRenter 
                                            SET FirstName = @firstName, LastName = @lastName, Phone = @phone
                                            WHERE Id = @renterId";

                    command.Parameters.AddWithValue("@renterId", renterId);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Renter GetById(int renterId)
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

        public void Remove(int renterId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM tblRenter WHERE Id = @renterId";

                    command.Parameters.AddWithValue("@renterId", renterId);
                    command.ExecuteNonQuery();
                }
            }
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
