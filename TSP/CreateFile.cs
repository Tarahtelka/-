using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    public static class CreateFile
    {
        public static int numberСolumns;

        public static double[] generateSample(string scale, string distr, int size)
        {
            Random rnd = new Random();

            List<double> sample = new List<double>(size);
            if (scale.Equals("дихотомическая"))
            {
                for (int i = 0; i < size; i++)
                {
                    sample.Add(rnd.Next(2));
                }
            }
            else if (scale.Equals("ранговая"))
            {
                if (distr.Equals("нормальное"))
                {
                    //MathNet.Numerics.Distributions.Normal nDistr = new MathNet.Numerics.Distributions.Normal(0, 5);
                    rnd.Next(7);
                    List<double> smp = new List<double>(size);

                    for (int i = 0; i < size; i++)
                    {
                        smp.Add(rnd.Next(7));
                    }

                    MathNet.Numerics.Distributions.Normal nDistr = new MathNet.Numerics.Distributions.Normal(0, 1);

                    for (int i = 0; i < size; i++)
                    {
                        sample.Add(Math.Ceiling(nDistr.Sample()));
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        sample.Add(rnd.Next(7));
                    }

                }

            }
            else if (scale.Equals("количественная"))
            {
                if (distr.Equals("нормальное"))
                {
                    MathNet.Numerics.Distributions.Normal nDistr = new MathNet.Numerics.Distributions.Normal(0, 2);
                    double[] arr = new double[size];
                    for (int i = 0; i < size; i++)
                    {
                        MathNet.Numerics.Distributions.Normal.Samples(arr, 0, 1);
                        sample = arr.ToList();
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        sample.Add(rnd.NextDouble() * 10);
                    }

                }
            }
            return sample.ToArray();
        }
    }
}
