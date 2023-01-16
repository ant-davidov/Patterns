using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Participant
    {
        private readonly ClassMediator mediator;
        public int Value { get; set; }

        public Participant(ClassMediator mediator)
        {
            this.mediator = mediator;
            mediator.Alert += Mediator_Alert;
        }

        private void Mediator_Alert(object sender, int e)
        {
            if (sender != this)
                Value += e;
        }

        public void Say(int n)
        {
            mediator.Broadcast(this, n);
        }
    }

    
}

