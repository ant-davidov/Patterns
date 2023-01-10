using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class NeuronLayer : Collection<Neuron>
    {
        public List<Neuron> NeuronList { get; set; }
        public NeuronLayer(int count)
        {
            while (count-- > 0)
                Add(new Neuron());
        }
    }
}
