// See https://aka.ms/new-console-template for more information
using PersonTask;

Console.WriteLine("Hello, World!");

Manager manager = new Manager("John", "Doe");
Developer developer = new Developer("Jane", "Smith");

manager.PrintInfo();
developer.PrintInfo();