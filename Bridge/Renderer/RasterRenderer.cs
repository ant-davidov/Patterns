using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    internal class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }
}
