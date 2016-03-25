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
    public class SqlRentsRepository : SqlBaseRepository, IRentsRepository
    {
        const string getRentsOnDateQuery = @"SELECT rent.[Id]
                                          ,rent.[RenterId]
	                                      ,renter.FirstName AS [RenterFirstName]
	                                      ,renter.LastName AS [RenterLastName]
	                                      ,renter.Phone AS [RenterPhone]
                                          ,rent.[ClassId]
	                                      ,ct.Id AS [ClassTypeId]
	                                      ,ct.Name AS [ClassName]
	                                      ,c.Area AS [ClassArea]
	                                      ,c.Rate AS [ClassRate]
                                          ,rent.[DateStart]
                                          ,rent.[DateEnd]
                                          ,rent.[Cost]
                                          ,rent.[Deleted]
                                          FROM [tblRent] rent
                                          INNER JOIN [tblRenter] renter ON rent.RenterId = renter.Id
                                          INNER JOIN [tblClass] c ON rent.ClassId = c.Id
                                          INNER JOIN [tblClassType] ct ON c.ClassTypeId = ct.Id
                                          WHERE (@Date <= rent.DateEnd 
                                                AND DATEPART(DAY, @Date) = DATEPART(DAY, rent.DateStart))
                                          AND rent.Deleted = 0";

        const string getAllRentsQuery = @"SELECT rent.[Id]
                                          ,rent.[RenterId]
	                                      ,renter.FirstName AS [RenterFirstName]
	                                      ,renter.LastName AS [RenterLastName]
	                                      ,renter.Phone AS [RenterPhone]
                                          ,rent.[ClassId]
	                                      ,ct.Id AS [ClassTypeId]
	                                      ,ct.Name AS [ClassName]
	                                      ,c.Area AS [ClassArea]
	                                      ,c.Rate AS [ClassRate]
                                          ,rent.[DateStart]
                                          ,rent.[DateEnd]
                                          ,rent.[Cost]
                                          ,rent.[Deleted]
                                          FROM [tblRent] rent
                                          INNER JOIN [tblRenter] renter ON rent.RenterId = renter.Id
                                          INNER JOIN [tblClass] c ON rent.ClassId = c.Id
                                          INNER JOIN [tblClassType] ct ON c.ClassTypeId = ct.Id";

        const string getRentsByRenterIdQuery = @"SELECT rent.[Id]
                                          ,rent.[RenterId]
	                                      ,renter.FirstName AS [RenterFirstName]
	                                      ,renter.LastName AS [RenterLastName]
	                                      ,renter.Phone AS [RenterPhone]
                                          ,rent.[ClassId]
	                                      ,ct.Id AS [ClassTypeId]
	                                      ,ct.Name AS [ClassName]
	                                      ,c.Area AS [ClassArea]
	                                      ,c.Rate AS [ClassRate]
                                          ,rent.[DateStart]
                                          ,rent.[DateEnd]
                                          ,rent.[Cost]
                                          ,rent.[Deleted]
                                          FROM [tblRent] rent
                                          INNER JOIN [tblRenter] renter ON rent.RenterId = renter.Id
                                          INNER JOIN [tblClass] c ON rent.ClassId = c.Id
                                          INNER JOIN [tblClassType] ct ON c.ClassTypeId = ct.Id
                                          WHERE renter.Id = @renterId AND rent.[Deleted] = 0";
        public SqlRentsRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IEnumerable<RentItem> GetRentsOnDate(DateTime inputDate)
        {
            var rents = new List<RentItem>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spGetRents";
                    command.Parameters.AddWithValue("@Date", inputDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rentItem = new RentItem()
                            {
                                Id = (int)reader["Id"],
                                Renter = new Renter()
                                {
                                    Id = (int)reader["RenterId"],
                                    FirstName = (string)reader["RenterFirstName"],
                                    LastName = (string)reader["RenterLastName"],
                                    Phone = (string)reader["RenterPhone"]
                                },
                                SportsHall = new SportsHall()
                                {
                                    Id = (int)reader["ClassId"],
                                    Type = new SportsHallType()
                                    {
                                        Id = (int)reader["ClassTypeId"],
                                        Name = (string)reader["ClassName"]
                                    },
                                    Area = (int)reader["ClassArea"],
                                    Rate = (decimal)reader["ClassRate"]
                                },
                                DateStart = (DateTime)reader["DateStart"],
                                DateEnd = (DateTime)reader["DateEnd"],
                                Cost = (decimal)reader["Cost"],
                                Deleted = (bool)reader["Deleted"]
                            };

                            rents.Add(rentItem);
                        }
                    }
                }
            }

            return rents;
        }

        public decimal Remove(int rentId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spRemoveRent";

                    command.Parameters.Add(new SqlParameter("@moneyChange",
                                                        SqlDbType.Money,
                                                        0,
                                                        ParameterDirection.Output,
                                                        false,
                                                        0,
                                                        0,
                                                        "tblRent",
                                                        DataRowVersion.Default,
                                                        null));
                    command.Parameters.AddWithValue("@rentID", rentId);

                    command.ExecuteNonQuery();
                    decimal moneyChange = Convert.ToDecimal(command.Parameters["@moneyChange"].Value);

                    return moneyChange;
                }
            }
        }

        public IEnumerable<RentItem> SelectAll()
        {
            var rents = new List<RentItem>();

            // Get data from database.
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = getAllRentsQuery;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rentItem = new RentItem()
                            {
                                Id = (int)reader["Id"],
                                Renter = new Renter()
                                {
                                    Id = (int)reader["RenterId"],
                                    FirstName = (string)reader["RenterFirstName"],
                                    LastName = (string)reader["RenterLastName"],
                                    Phone = (string)reader["RenterPhone"]
                                },
                                SportsHall = new SportsHall()
                                {
                                    Id = (int)reader["ClassId"],
                                    Type = new SportsHallType()
                                    {
                                        Id = (int)reader["ClassTypeId"],
                                        Name = (string)reader["ClassName"]
                                    },
                                    Area = (int)reader["ClassArea"],
                                    Rate = (decimal)reader["ClassRate"]
                                },
                                DateStart = (DateTime)reader["DateStart"],
                                DateEnd = (DateTime)reader["DateEnd"],
                                Cost = (decimal)reader["Cost"],
                                Deleted = (bool)reader["Deleted"]
                            };

                            rents.Add(rentItem);
                        }
                    }
                }
            }

            return rents;
        }

        public IEnumerable<RentItem> GetRentsByRenterId(int renterId)
        {
            var rents = new List<RentItem>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = getRentsByRenterIdQuery;
                    command.Parameters.AddWithValue("@renterId", renterId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rentItem = new RentItem()
                            {
                                Id = (int)reader["Id"],
                                Renter = new Renter()
                                {
                                    Id = (int)reader["RenterId"],
                                    FirstName = (string)reader["RenterFirstName"],
                                    LastName = (string)reader["RenterLastName"],
                                    Phone = (string)reader["RenterPhone"]
                                },
                                SportsHall = new SportsHall()
                                {
                                    Id = (int)reader["ClassId"],
                                    Type = new SportsHallType()
                                    {
                                        Id = (int)reader["ClassTypeId"],
                                        Name = (string)reader["ClassName"]
                                    },
                                    Area = (int)reader["ClassArea"],
                                    Rate = (decimal)reader["ClassRate"]
                                },
                                DateStart = (DateTime)reader["DateStart"],
                                DateEnd = (DateTime)reader["DateEnd"],
                                Cost = (decimal)reader["Cost"],
                                Deleted = (bool)reader["Deleted"]
                            };

                            rents.Add(rentItem);
                        }
                    }
                }
            }

            return rents;
        }

        public int MakeRent(int renterId, int sportsHallId, DateTime dateStart, DateTime dateEnd, decimal Cost)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spMakeRent";

                    command.Parameters.Add(new SqlParameter("@rentId",
                                                        SqlDbType.Int,
                                                        0,
                                                        ParameterDirection.Output,
                                                        false,
                                                        0,
                                                        0,
                                                        "tblRent",
                                                        DataRowVersion.Default,
                                                        null));

                    command.Parameters.AddWithValue("@renterId", renterId);
                    command.Parameters.AddWithValue("@sportsHallId", sportsHallId);
                    command.Parameters.AddWithValue("@dateStart", dateStart);
                    command.Parameters.AddWithValue("@dateEnd", dateEnd);
                    command.Parameters.AddWithValue("@cost", Cost);

                    command.ExecuteNonQuery();
                    int rentId = (int)command.Parameters["@rentId"].Value;

                    return rentId;
                }
            }
        }
    }
}
