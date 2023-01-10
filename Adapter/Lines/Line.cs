using Adapter.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter.Lines
{
    internal class Line
    {
       public Point Start, End ;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override int GetHashCode()
        {
            return Start.X + Start.Y + End.X + End.Y;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Point p) return p.GetHashCode() == GetHashCode();
            return false;
        }
    }
}
