using HWYDotNetCore.ConsoleAppEFCore.Databases.Models;

// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Hello, World!");

AppDbContext db = new AppDbContext();
db.TblPieCharts.ToList();
