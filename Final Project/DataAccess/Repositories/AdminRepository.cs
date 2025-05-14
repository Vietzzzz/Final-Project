using Final_Project.DataAccess.Interfaces;
using Final_Project.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        public DBContext dbContext { get; set; }

        public AdminRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Admin ValidateCredential(string username, string password)
        {

            using (var connection = dbContext.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM admins WHERE username = @username AND password = @password";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Admin
                            {
                                AdminId = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
