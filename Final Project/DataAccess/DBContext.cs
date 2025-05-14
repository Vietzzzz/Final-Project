using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccess
{

        public class DBContext
        {
            private readonly string _connectionString;

            public DBContext()
            {
                _connectionString = ConfigurationManager.ConnectionStrings["PostgreSQLConnection"].ConnectionString;
            }

            public NpgsqlConnection GetConnection()
            {
                return new NpgsqlConnection(_connectionString);
            }
        }

}
