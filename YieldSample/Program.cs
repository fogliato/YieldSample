// See https://aka.ms/new-console-template for more information
using YieldSample;

Console.WriteLine("Hello, World!");

var yieldSample = new YieldSamplePratice();
Console.WriteLine("Get2025CarsWithYield:");
foreach (var car in yieldSample.Get2025CarsWithYield())
{
    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
}
Console.WriteLine("Get2025CarsWithoutYield:");
foreach (var car in yieldSample.Get2025CarsWithoutYield())
{
    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
}
