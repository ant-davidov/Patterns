// See https://aka.ms/new-console-template for more information
using Adapter.Adapter;
using Adapter.Lines;

Console.WriteLine("Hello, World!");

var rectangle = new VectorRectangle(1, 1, 10, 10);

foreach (var line in rectangle)  
    foreach (var p in new LineToPointAdapter(line))
        Console.WriteLine($"X = {p.X} Y = {p.Y} ");

    