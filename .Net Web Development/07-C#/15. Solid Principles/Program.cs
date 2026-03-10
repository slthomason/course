// See https://aka.ms/new-console-template for more information
using _15_solid_principles;

Console.WriteLine("Hello, World!");
Triangle triangle = new Circle();
Console.WriteLine(triangle.GetShape());




IAutomobile automobile = new Jeep();
//IAutomobile automobile = new SUV();
AutomobileController automobileController = new AutomobileController(automobile);
automobile.Ignition();
automobile.Stop();

Console.Read();