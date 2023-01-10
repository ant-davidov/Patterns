// See https://aka.ms/new-console-template for more information
using Builder.Builder;
using Builder.CompositeBuilder.Builders;
using Builder.CompositeBuilder;
using Builder.FluentBuilder;

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
Console.WriteLine(builder.ToString());

// fluent builder
var builder2 = new FluentHtmlBuilder("ul");
builder2.AddChild("li", "hello").AddChild("li", "world");
HtmlElement t = builder2;
Console.WriteLine(t.ToString());


//Composite Builder
var pb = new PersonBuilder();
Person person = pb
  .Lives
    .At("123 London Road")
    .In("London")
    .WithPostcode("SW12BC")
  .Works
    .At("Fabrikam")
    .AsA("Engineer")
    .Earning(123000);

Console.WriteLine(person);