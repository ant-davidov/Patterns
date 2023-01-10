using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Renderer
{
    internal interface IRenderer
    {
        string WhatToRenderAs { get; }
    }
}
