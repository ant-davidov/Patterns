using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ClassMediator
    {
        public void Broadcast(object sender, int n)
        {
            Alert?.Invoke(sender, n);
        }

        public event EventHandler<int> Alert;
    }
}
