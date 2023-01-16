using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.BrokerChain
{
    internal class NewCreature
    {
        private readonly Game game;
        public string Name;
        private readonly int attack;
        private readonly int defense;

        public NewCreature(Game game, string name, int attack, int defense)
        {
            this.game = game;
            this.Name = name;
            this.attack = attack;
            this.defense = defense;
        }

        public int Attack
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack, attack);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public int Defense
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defense, defense);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public override string ToString() 
        {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(attack)}: {Attack}, " +
                   $"{nameof(defense)}: {Defense}";
           
        }
    }
}
