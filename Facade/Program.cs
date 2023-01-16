// See https://aka.ms/new-console-template for more information
using Facade.Facade;
using System.Text;

string SquareToString(List<List<int>> square)
{
    var sb = new StringBuilder();
    foreach (var row in square)
    {
        sb.AppendLine(string.Join(" ",
          row.Select(x => x.ToString())));
    }

    return sb.ToString();
}
var gen = new FacadeMagicSquareGenerator();
var square = gen.Generate(4);

Console.WriteLine(SquareToString(square));