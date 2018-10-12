using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuros.Neurons
{
      public abstract class Neuron
      {
            protected double [] w;

            protected double bias = 0;

            public Neuron(Int32 m)
            {
                w = new double[m];
            }

            public double[] W { get { return w; } }

            public double GetConnection (int from)
            {
                return w[from];
            }

            public double Transfer(double [] x)
            {
                return Activator(Summator(x));
            }

            public double Summator(double [] x)
            {
                return x.Select((t, i) => t * w[i]).Sum() + bias;
            }


            public void ChangeWeights(double v, double d, double[] x)
            {
                for (var i = 0; i < w.Count(); i++)
                {
                    w[i] += v * d * x[i];
                }
                bias += d * v;
            }

            protected abstract double Activator(double x);

            public void InitWeights()
            {
                var rand = new Random((int)DateTime.Now.Ticks);

                for (var i = 0; i < w.Count(); i++)
                {
                    w[i] = -0.05 + 0.1 * rand.NextDouble();
                }
            }
      }

}
