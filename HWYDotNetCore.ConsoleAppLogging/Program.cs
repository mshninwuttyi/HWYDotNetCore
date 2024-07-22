// See https://aka.ms/new-console-template for more information
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/HWYDotNetCore.ConsoleAppLogging.txt", rollingInterval: RollingInterval.Hour)
    .CreateLogger();

Log.Fatal("Hello, World Fatal");
Log.Error("Hello, World Error");
Console.WriteLine("Hello, World!");
int a = 10,
    b = 0;
try
{
    Log.Debug("Dividing {A} by {B}", a, b);
    Console.WriteLine(a / b);
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong");
}
finally
{
    await Log.CloseAndFlushAsync();
}
