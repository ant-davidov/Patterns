using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    internal class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Creature creature): base(creature) { }

        public override void Handle()
        {
            if (creature.Attack <= 4)
            {
                Console.WriteLine($"Increasing {creature.Name}'s defense");
                creature.Defense++;
            }

            base.Handle();
        }
    }
}
