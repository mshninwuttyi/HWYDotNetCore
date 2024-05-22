// See https://aka.ms/new-console-template for more information
using HWYDotNetCore.ConsoleAppRestClientExamples;
using RestSharp;

Console.WriteLine("Hello, World!");
RestClientExample restClient = new RestClientExample();
await restClient.RunAsync();

Console.ReadLine();