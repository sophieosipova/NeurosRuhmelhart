using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using neuros.Neurons;

namespace neuros.Layer
{
    class ALayer : Layer
    {
        public ALayer(int neuronCount, int m, double speed) : base(neuronCount, m, speed)
        {
            neurons = new ANeuron[neuronCount];
            for (var j = 0; j < neuronCount; j++)
            {
                neurons[j] = new ANeuron(m);
            }
        }

        public void SetSigma(Layer lastLayer)
        {
            for (var j = 0; j < neuronCount; j++)
            {
                double s = 0;
                for (int i = 0; i < lastLayer.GetSigma().Count(); i++)
                    s += lastLayer.GetConnection(j, i) * lastLayer.GetSigma()[i];

                sigma[j] = Outputs[j] * (1 - Outputs[j]) * s;
            }
        }
    }
}
