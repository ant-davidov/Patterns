using Adapter.Lines;
using Adapter.Points;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    internal class LineToPointAdapter : IEnumerable<Point>
    {

        static Dictionary<int, List<Point>> cache = new Dictionary<int, List<Point>>();
        private int hash;
        public LineToPointAdapter(Line line)
        {
            hash = line.GetHashCode();
            if (cache.ContainsKey(hash))
            { Console.WriteLine("Return from cache"); 
                return;
            }
               
           
            Console.WriteLine($"points for line"
              + $" [{line.Start.X},{line.Start.Y}]-"
              + $"[{line.End.X},{line.End.Y}]");

            int left = Math.Min(line.Start.X, line.End.X);
            int right = Math.Max(line.Start.X, line.End.X);
            int top = Math.Min(line.Start.Y, line.End.Y);
            int bottom = Math.Max(line.Start.Y, line.End.Y);
            List<Point> points = new List<Point>();
            if (right - left == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    points.Add(new Point(left, y));
                }
            }
            else if (line.End.Y - line.Start.Y == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    points.Add(new Point(x, top));
                }
            }
            cache.Add(hash, points);

        }

        public IEnumerator<Point> GetEnumerator()
        {
            return cache[hash].GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
