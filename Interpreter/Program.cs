// See https://aka.ms/new-console-template for more information
using Interpreter;

var ep = new ExpressionProcessor();
ep.Variables.Add('x', 5);
Console.WriteLine($"1+2 = {ep.Calculate("1+2")}");
Console.WriteLine($"1+x = {ep.Calculate("1+x")}");