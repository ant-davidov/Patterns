using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.BrokerChain.Modifiers
{
    internal abstract class NewCreatureModifier : IDisposable
    {
        protected readonly Game game;
        protected readonly NewCreature creature;

        protected NewCreatureModifier(Game game, NewCreature creature)
        {
            this.game = game;
            this.creature = creature;
            game.Queries += Handle;
        }

        protected abstract void Handle(object sender, Query q);

        public void Dispose()
        {
            game.Queries -= Handle;
        }
    }
}
