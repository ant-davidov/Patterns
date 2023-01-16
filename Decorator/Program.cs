// See https://aka.ms/new-console-template for more information
using Decorator.Decorator;
Console.WriteLine("Age = 0");
var dragon = new Dragon();
Console.WriteLine(dragon.Fly());    
Console.WriteLine(dragon.Crawl()); 

dragon.Age = 20;
Console.WriteLine("Age = 20");  
Console.WriteLine(dragon.Fly());
Console.WriteLine(dragon.Crawl());
