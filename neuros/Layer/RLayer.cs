using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using neuros.Neurons;

namespace neuros.Layer
{
    class RLayer : Layer
    {
        public RLayer(int neuronCount, int m, double speed) : base(neuronCount, m, speed)
        {
            neurons = new RNeuron[neuronCount];
            for (var j = 0; j < neuronCount; j++)
            {
                neurons[j] = new RNeuron(m);
            }
        }

        public void SetSigma(double[] result)
        {
            for (var j = 0; j < neuronCount; j++)
            {
                sigma[j] = Outputs[j] * (1 - Outputs[j]) * (result[j] - Outputs[j]);
            }
        }

    }
}
