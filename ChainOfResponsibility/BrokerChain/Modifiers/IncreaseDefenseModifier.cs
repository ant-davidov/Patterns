using ChainOfResponsibility.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.BrokerChain.Modifiers
{
    internal class NewIncreaseDefenseModifier : NewCreatureModifier
    {
        public NewIncreaseDefenseModifier(Game game, NewCreature creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name && q.WhatToQuery == Query.Argument.Defense)
                q.Value += 2;
        }
    }
}
