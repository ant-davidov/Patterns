using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.BrokerChain
{
    internal class Query
    {
        public string CreatureName;
        public enum Argument
        {
            Attack, Defense
        }

        public Argument WhatToQuery;

        public int Value; 

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName;
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }
}
