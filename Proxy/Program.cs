// See https://aka.ms/new-console-template for more information

using Proxy.ProtectionProxy.Interfaces;
using Proxy.ProtectionProxy;
using Proxy.VirtualProxy;
using Proxy.VirtualProxy.Interfaces;

//Protection Proxy
ICar car = new CarProxy(new Driver(22)); //12
car.Drive();


//VirtualProxy
Console.WriteLine("\n\n\n\nVirtualProxy :");
var img = new Bitmap("pokemon.png");
var img2 = new LazyBitmap("pokemon.png");
//DrawImage(img);

static void DrawImage(IImage img)
{
    Console.WriteLine("About to draw the image");
    img.Draw();
    Console.WriteLine("Done drawing the image");

}
