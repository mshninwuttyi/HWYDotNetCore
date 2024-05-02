using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWYDotNetCore.ConsoleApp.Services
{
    internal static class ConnectionStrings
    {
        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "HNINWUTTYI\\MSSQLSERVER2012",
            InitialCatalog = "HWYDotNetCore",
            UserID = "sa",
            Password = "admin123!",
            TrustServerCertificate = true,
        };

    }
}
