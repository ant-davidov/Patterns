using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Flyweight
{
    internal class TextRange
    {
        public int Start, End;
        public bool Capitalize;

        public bool Covers(int position)
        {
            return position >= Start && position <= End;
        }
    }
}
 