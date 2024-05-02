// See https://aka.ms/new-console-template for more information
using HWYDotNetCore.ConsoleApp.AdoDotNetExamples;
using HWYDotNetCore.ConsoleApp.EFCoreExamples;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//Ctrl + .  => Suggestion

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(13, "testing title", "test author", "test content");
//adoDotNetExample.Delete(13);
//adoDotNetExample.Edit(13);
//adoDotNetExample.Edit(1);

//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Run();

Console.ReadLine();