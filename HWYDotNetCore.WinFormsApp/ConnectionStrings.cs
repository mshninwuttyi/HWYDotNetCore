using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWYDotNetCore.WinFormsApp
{
    internal static class ConnectionStrings
    {
        public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new()
        {
            DataSource = "HNINWUTTYI\\MSSQLSERVER2012",
            InitialCatalog = "HWYDotNetCore",
            UserID = "sa",
            Password = "admin123!",
            TrustServerCertificate = true,
        };

    }
}
