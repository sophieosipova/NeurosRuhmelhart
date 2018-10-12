using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuros.Neurons
{
    public class ANeuron : Neuron
    {
        private double alpha = 3.0;
        public ANeuron(int m) : base(m)
        {

        }

        protected override double Activator(double x)
        {
            return 1 / (1 + Math.Exp(-alpha * x));
        }
    }
}
