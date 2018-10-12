using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuros.Neurons
{
    public class RNeuron : Neuron
    {
        double alpha = 1.5;
        public RNeuron(int m) : base(m)
        {

        }

        protected override double Activator(double x)
        {
            return 1 / (1 + Math.Exp(-alpha * x));
        }
    }
}
