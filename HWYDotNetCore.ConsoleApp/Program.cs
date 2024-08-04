// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
using HWYDotNetCore.ConsoleApp.AdoDotNetExamples;
using HWYDotNetCore.ConsoleApp.DapperExamples;
using HWYDotNetCore.ConsoleApp.EFCoreExamples;
using HWYDotNetCore.ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

//Ctrl + .  => Suggestion

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(13, "testing title", "test author", "test content");
//adoDotNetExample.Delete(13);
//adoDotNetExample.Edit(13);
//adoDotNetExample.Edit(1);

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Run();

var connectionString = ConnectionStrings.SqlConnectionStringBuilder.ConnectionString;
var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);

var serviceProvider = new ServiceCollection()
    .AddScoped(n => new AdoDotNetExample(sqlConnectionStringBuilder))
    .AddScoped(n => new DapperExample(sqlConnectionStringBuilder))
    .AddDbContext<AppDbContext>(opt =>
    {
        opt.UseSqlServer(connectionString);
    })
    .AddScoped<EFCoreExample>()
    .BuildServiceProvider();

//AppDbContext db = serviceProvider.GetRequiredService<AppDbContext>();

//var adoDotNetExample = serviceProvider.GetRequiredService<AdoDotNetExample>();
//adoDotNetExample.Read();

//var dapperExample = serviceProvider.GetRequiredService<DapperExample>();
//dapperExample.Run();

EFCoreExample eFCoreExample = serviceProvider.GetRequiredService<EFCoreExample>();
eFCoreExample.Generate(391);

int pageSize = 10;
AppDbContext db = serviceProvider.GetRequiredService<AppDbContext>();
int rowCount = db.Blogs.Count();

int pageCount = rowCount / pageSize;
Console.WriteLine($"Current Page Count: {pageCount}");
if (rowCount % pageSize > 0)
{
    pageCount++;
    Console.WriteLine($"Current Page Count: {pageCount}");
}
Console.ReadKey();
