using DogGo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Mail;

namespace DogGo.Repositories
{
    public class WalkerRepository : IWalkerRepository
    {
        private readonly IConfiguration _config;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public WalkerRepository(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public List<Walker> GetAllWalkers()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                  SELECT w.Id, w.Name, w.ImageUrl, w.NeighborhoodId, n.Name as NeighborhoodName
                        FROM Walker w
                        JOIN Neighborhood n ON n.Id = w.NeighborhoodId
                    ";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Walker> walkers = new List<Walker>();
                        while (reader.Read())
                        {
                            Walker walker = new Walker
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                ImageUrl = reader.GetString(reader.GetOrdinal("ImageUrl")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                Neighborhood = new Neighborhood()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("NeighborhoodName"))
                                },
                            };

                            walkers.Add(walker);
                        }

                        return walkers;
                    }
                }
            }
        }
        public List<Walker> GetWalkersInNeighborhood(int neighborhoodId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT Id, [Name], ImageUrl, NeighborhoodId
                FROM Walker
                WHERE NeighborhoodId = @neighborhoodId
            ";

                    cmd.Parameters.AddWithValue("@neighborhoodId", neighborhoodId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        List<Walker> walkers = new List<Walker>();
                        while (reader.Read())
                        {
                            Walker walker = new Walker
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                ImageUrl = reader.GetString(reader.GetOrdinal("ImageUrl")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId"))
                            };

                            walkers.Add(walker);
                        }

                        return walkers;
                    }
                }
            }
        }
        public Walker GetWalkerById(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT wr.Id as WalkerId, wr.Name as WalkerName, wr.ImageUrl, w.Id as WalkId, w.Date as WalkDate, w.Duration as Duration,wr.NeighborhoodId, n.Name as NeighborhoodName,w.DogId,d.Name as DogName,d.OwnerId, o.Name as Client
                        FROM Walker wr
                        Left JOIN Walks w ON w.WalkerId = wr.Id
                        Left JOIN Neighborhood n ON n.Id = wr.NeighborhoodId
                        Left JOIN Dog d ON d.Id = w.DogId
                        Left JOIN Owner o ON o.Id = d.OwnerId
                        WHERE wr.Id = @id
                    ";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Walker walker = null;
                        while (reader.Read())
                        {
                            if (walker == null)
                            {
                                walker = new Walker
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                    Name = reader.GetString(reader.GetOrdinal("WalkerName")),
                                    ImageUrl = reader.GetString(reader.GetOrdinal("ImageUrl")),
                                    NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                    Neighborhood = new Neighborhood
                                    {
                                        Id = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                        Name = reader.GetString(reader.GetOrdinal("NeighborhoodName")),

                                    },
                                    Walks = new List<Walks>()
                                };

                            }
                            if (!reader.IsDBNull(reader.GetOrdinal("WalkId")))
                            {
                                walker.Walks.Add(
                                    new Walks
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("WalkId")),
                                    Date = reader.GetDateTime(reader.GetOrdinal("WalkDate")),
                                    Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                    Dog = new Dog()
                                    {
                                        Id = reader.GetInt32(reader.GetOrdinal("OwnerID")),
                                        Name = reader.GetString(reader.GetOrdinal("DogName")),
                                        Owner = new Owner
                                        {
                                            Id = reader.GetInt32(reader.GetOrdinal("OwnerId")),
                                            Name = reader.GetString(reader.GetOrdinal("Client")),
                                        }
                                    }
                                });
                            }
                        }
                        return walker;
                    }
                }
            }
        }
    }
}
    
