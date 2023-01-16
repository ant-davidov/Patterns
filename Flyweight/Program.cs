// See https://aka.ms/new-console-template for more information
using Flyweight;
using Flyweight.Flyweight;

Console.WriteLine("Hello, World!");



var bft = new FormattedText("This is a brave new world");
bft.GetRange(10, 15).Capitalize = true;
Console.WriteLine(bft);

var s = new Sentence("alpha beta gamma");
s[1].Italic = true;
s[1].Capitalize = true;


