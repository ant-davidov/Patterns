﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            var newStart = new Point { X = Start.X, Y = Start.Y };
            var newEnd = new Point { X = End.X, Y = End.Y };
            return new Line { Start = newStart, End = newEnd };
        }

        public override string ToString()
        {
            return  Start.ToString() + " " + End.ToString();
        }
    }
}
