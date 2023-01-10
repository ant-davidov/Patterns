using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentBuilder
{
    internal class FluentHtmlBuilder
    {
        private readonly string rootName;
        protected HtmlElement root = new HtmlElement();
        public FluentHtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public FluentHtmlBuilder AddChild(string tag, string text)
        {
            root.Elements.Add(new HtmlElement(tag, text));
            return this;
        }
        public static implicit operator HtmlElement(FluentHtmlBuilder builder)
        {
            return builder.root;
        }
        public override string ToString()
        {
            return root.ToString();
        }
    }
}
