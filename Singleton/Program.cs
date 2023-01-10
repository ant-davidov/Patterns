// See https://aka.ms/new-console-template for more information
using Singleton.Singleton;
var db = SingletonDatabase.Instance;
var letter = "A";
Console.WriteLine($"{letter} number {db.GetInfo(letter)}");

var db2 = SingletonDatabase.Instance;
var letter2 = "B";
Console.WriteLine($"{letter2} number {db.GetInfo(letter2)}");

Console.WriteLine($"Количество вызовов = {SingletonDatabase.Count}") ;
