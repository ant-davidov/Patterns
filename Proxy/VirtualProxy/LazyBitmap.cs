using Proxy.VirtualProxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.VirtualProxy
{
    internal class LazyBitmap : IImage
    {
        private readonly string filename;
        private Bitmap bitmap;

        public LazyBitmap(string filename)
        {
            this.filename = filename;
        }


        public void Draw()
        {
            if (bitmap == null)
                bitmap = new Bitmap(filename);
            bitmap.Draw();
        }
    }
}
