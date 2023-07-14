using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DbConstans
    {
        public const string DB_HOST = "localhost";
        public const string DB_PORT = "5432";
        public const string DB_DATABASE = "User";
        public const string DB_USER = "postgres";
        public const string DB_PASSWORD = "Ankabut";

        public const string DB_CONNECTIONSTRING = $"Host={DB_HOST};" +
            $"Port={DB_PORT};" +
            $"Database={DB_DATABASE};" +
            $"User ID={DB_USER};" +
            $"Password={DB_PASSWORD}";
}
}
