using Bridge.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    internal abstract class Shape
    {
        private IRenderer rendering;

        protected Shape(IRenderer rendering)
        {
            this.rendering = rendering;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {rendering.WhatToRenderAs}";
        }
    }
}
