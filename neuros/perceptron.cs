using System;
using System.Collections.Generic;
using System.Linq;
using neuros.Data;
using neuros.Layer;

namespace neuros
{
    public class Perceptron
    {
        private ALayer aLayer;
        private RLayer rLayer;
        private  int neuronCount = 0;
        double q = 0;

        public Perceptron(Int32 neuronCount, Int32 m, double speed)
        {
            this.neuronCount = neuronCount;
            int ac = 20;
            aLayer = new ALayer(ac, m, speed);
            rLayer = new RLayer(neuronCount, ac, speed);
            InitWeights();
        }

        public void InitWeights()
        {
            aLayer.InitWeights();
            rLayer.InitWeights();
        }

        public double[] Recognize(double [] x)
        {
            double [] y = aLayer.Solve(x);
            return rLayer.Solve(y);
        }

        public void Correct (double [] inputs, double [] result)
        {
            rLayer.SetSigma(result);
            aLayer.SetSigma(rLayer);

            rLayer.CorrectLayer(aLayer.Outputs);
            aLayer.CorrectLayer(inputs);
        }


        public void Teach(double[] x, double [] y)
        {
            var t = Recognize(x);
            Correct(x, y);
            SetQ(y, t);
        }

        
        private void SetQ (double []  result, double [] y)
        {
            for (int i =0; i< result.Count(); i++)
            {
                q += (result[i] - y[i]) * (result[i] - y[i]);
            }
        }

        private double getQ(int n)
        {
            q= q / n / neuronCount;
            return q ;
        }

        private void nullQ()
        {
            q = 0;
        }

        private bool Stop (double[] result, double[] y)
        {
            return result.Select((t, i) => Math.Abs(t - y[i])).Max() < 0.1;
        }

        public void Teach(ICollection<ImageData> images)
        {
            do
            {
                nullQ();
                foreach (var item in images)
                {
                    var y = GetOutVector(Convert.ToInt32(item.Class));
                    Teach(item.Data, y);
                }
            } while (getQ(images.Count()) > 0.001);

        }

        private double[] GetOutVector(Int32 n)
        {
            var y = new double[neuronCount];
            if (neuronCount > n)
                y[n] = 1;
            return y;
        }

        public Int32 GetNeuronCount
        {
            get { return neuronCount; }
        }

    }
}
