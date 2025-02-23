using System.Text;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using MovieTrackingApp.Models;
using Microsoft.Extensions.Configuration;

namespace MovieTrackingApp.API_and_DB_Calls
{
        public class DBCalls
        {
            private readonly string _connectionString;

            public DBCalls(IConfiguration configuration)
            {
                _connectionString = configuration.GetConnectionString("DefaultConnection");
            }

            private byte[] HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                }
            }

            public bool CreateUser(string username, string password, string email)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO UserInfo (Username, PasswordHash, Email) VALUES (@Username, @PasswordHash, @Email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
                        command.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }

            public bool VerifyLogin(string username, string password)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT PasswordHash FROM UserInfo WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            byte[] storedHash = (byte[])result;
                            byte[] inputHash = HashPassword(password);
                            return storedHash.SequenceEqual(inputHash);
                        }
                        return false;
                    }
                }
            }

            public bool AddOrUpdateUserMovie(string userId, int movieId, bool watched, int? rating = null)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = @"
                    MERGE INTO UserMovies AS target
                    USING (VALUES (@UserId, @MovieId)) AS source (UserId, MovieId)
                    ON target.UserId = source.UserId AND target.MovieId = source.MovieId
                    WHEN MATCHED THEN
                        UPDATE SET Watched = @Watched, Rating = @Rating, DateAdded = @DateAdded
                    WHEN NOT MATCHED THEN
                        INSERT (UserId, MovieId, Watched, Rating, DateAdded)
                        VALUES (@UserId, @MovieId, @Watched, @Rating, @DateAdded);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@MovieId", movieId);
                        command.Parameters.AddWithValue("@Watched", watched);
                        command.Parameters.AddWithValue("@Rating", rating ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DateAdded", DateTime.Now);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }

            public List<UserMovie> GetUserMovies(string userId)
            {
                List<UserMovie> userMovies = new List<UserMovie>();

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM UserMovies WHERE UserId = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userMovies.Add(new UserMovie
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    UserId = reader.GetString(reader.GetOrdinal("UserId")),
                                    MovieId = reader.GetInt32(reader.GetOrdinal("MovieId")),
                                    Watched = reader.GetBoolean(reader.GetOrdinal("Watched")),
                                    Rating = reader.IsDBNull(reader.GetOrdinal("Rating")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("Rating")),
                                    DateAdded = reader.GetDateTime(reader.GetOrdinal("DateAdded"))
                                });
                            }
                        }
                    }
                }

                return userMovies;
            }
        }
    }
