using Prototype;

var line1 = new Line
{
    Start = new Point { X = 3, Y = 3 },
    End = new Point { X = 10, Y = 10 }
};
var line2 = line1.DeepCopy();
line1.Start.X = line1.End.X = line1.Start.Y = line1.End.Y = 0;

Console.WriteLine(line1.ToString());
Console.WriteLine(line2.ToString());

Console.WriteLine(line1.GetHashCode());
Console.WriteLine(line2.GetHashCode());

