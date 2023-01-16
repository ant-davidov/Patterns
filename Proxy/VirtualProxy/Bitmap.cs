using Proxy.VirtualProxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.VirtualProxy
{
    internal class Bitmap : IImage
    {
        private readonly string filename;

        public Bitmap(string filename)
        {
            this.filename = filename;
            Console.WriteLine($"Loading image from {filename}");
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing image {filename}");
        }
    }
}
