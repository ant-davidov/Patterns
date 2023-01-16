using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    internal class NoBonusesModifier : CreatureModifier
    {
        public NoBonusesModifier(Creature creature) : base(creature) { }

        public override void Handle()
        {
            Console.WriteLine("No bonuses for you!");
        }
    }
}
