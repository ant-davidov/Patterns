using Bridge.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bridge.Shapes
{
    internal class Triangle : Shape
    {
        public Triangle(IRenderer strategy) : base(strategy)
        {
            Name = "Triangle";
        }
    }
}
