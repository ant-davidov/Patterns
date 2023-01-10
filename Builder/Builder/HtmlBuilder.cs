using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class HtmlBuilder
    {
        private readonly string rootName;
        protected HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public void AddChild(string tag, string text)
        {
            root.Elements.Add(new HtmlElement(tag, text));
        }
        public static implicit operator HtmlElement(HtmlBuilder builder)
        {
            return builder.root;
        }
        public override string ToString() 
        {
            return root.ToString();
        }
        
    }
}
