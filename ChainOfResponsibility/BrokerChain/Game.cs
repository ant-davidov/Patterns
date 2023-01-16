using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.BrokerChain
{
    internal class Game
    {
        public event EventHandler<Query> Queries; 

        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}
