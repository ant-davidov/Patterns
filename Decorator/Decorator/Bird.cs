using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    internal class Bird
    {
        public int Age {get; set;}
        public string Fly()
        {
           return (Age < 10) ? "Fly" : "Too old";
        }
    }
}
