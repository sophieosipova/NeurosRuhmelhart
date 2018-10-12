using System;
using System.Collections.Generic;
using neuros.Neurons;
using System.Text;
using System.Threading.Tasks;

namespace neuros.Layer
{
    abstract class Layer
    {
        protected IList<Neuron> neurons;
        protected int neuronCount;
        protected int m;
        public double [] Outputs { get; private set; }
        protected double speed;
        protected double[] sigma;

        public Layer(int neuronCount, int m, double speed)
        {
            this.speed = speed;
            this.neuronCount = neuronCount;
            this.m = m;
            this.sigma = new double[neuronCount];
        }

        public double[] Solve(double[] inputs)
        {
            var y = new double[neuronCount];
            for (var j = 0; j < neuronCount; j++)
            {
                y[j] = neurons[j].Transfer(inputs);
            }
            Outputs = y;
            return Outputs;
        }

        public void InitWeights ()
        {
            for (var j = 0; j < neuronCount; j++)
            {
                neurons[j].InitWeights();
            }
        }

        public IList<Neuron> Neurons { get { return neurons; }  }
        
        public void CorrectLayer(double [] inputs)
        {
            for (var j = 0; j < neurons.Count; j++)
            {
                neurons[j].ChangeWeights(speed, sigma[j], inputs);
            }
        }

        public double[] GetSigma()
        {
            return sigma;
        }

        public double GetConnection(int from, int to)
        {
            return neurons[to].GetConnection(from);
        }
    }
}
