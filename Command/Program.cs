// See https://aka.ms/new-console-template for more information

using Command;

var a = new Account();
Console.WriteLine("Balance = " + a.Balance);
var command = new CommandClass { Amount = 100, TheAction = CommandClass.Action.Deposit };
a.Process(command);
Console.WriteLine("Balance = " + a.Balance);