using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    internal class Lizard
    {
        public int Age {get; set;}

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }
}
