using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    internal class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature) : base(creature) { }

        public override void Handle()
        {
            Console.WriteLine($"Doubling {creature.Name}'s attack");
            creature.Attack *= 2;
            base.Handle();
        }
    }
}
