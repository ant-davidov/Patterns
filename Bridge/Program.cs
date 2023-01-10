// See https://aka.ms/new-console-template for more information
using Bridge.Renderer;
using Bridge.Shapes;

var render = new RasterRenderer();

var t = new Triangle(render);
Console.WriteLine(t.ToString());

