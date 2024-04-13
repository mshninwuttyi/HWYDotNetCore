// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//Ctrl + .  => Suggestion

SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "HNINWUTTYI\\MSSQLSERVER2012"; //server name
stringBuilder.InitialCatalog = "HWYDotNetCore"; //database name
stringBuilder.UserID = "sa";
stringBuilder.Password = "admin123!";
SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection Open");

connection.Close();
Console.WriteLine("Connection Close");

Console.ReadKey();