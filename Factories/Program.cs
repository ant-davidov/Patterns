// See https://aka.ms/new-console-template for more information
using Factories.AsyncFactories;
using Factories.Factories;
using static Factories.Factories.Person;

var pf = new PersonFactory();
var p1 = pf.CreatePerson("Chris");
var p2 = pf.CreatePerson("Sarah");
Console.WriteLine(p1.Id + " " + p2.Id);

// Async 
var foo = await Foo.CreateAsync();
