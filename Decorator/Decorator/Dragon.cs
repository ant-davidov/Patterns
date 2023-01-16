using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
  
    public class Dragon 
    {
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();
        public int Age
        {
            set { bird.Age = lizard.Age = value; }
            get { return bird.Age; }
        }
        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return lizard.Crawl();
        }
    }
}
