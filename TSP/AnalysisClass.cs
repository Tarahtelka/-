using Accord.Statistics.Models.Regression.Fitting;
using MachineLearningLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocenka_mer_svyzei
{
    class AnalysisClass
    {
        //максимальное кол-во значений для ранговой шкалы
        public static int N = 7;

        //максимальный объем выборки при использовании КК Спирмена
        public static int SPEARMAN_SIZE = 30;

        public static string getScale(int valuesCount)
        {
            if (valuesCount == 2)
            {
                return "дихотомическая";
            }
            else if (valuesCount > 2 && valuesCount <= N)
            {
                return "ранговая";
            } else if (valuesCount > N)
            {
                return "количественная";
            }

            return "невозможно определить шкалу";
        }

        public static string getDistributionScale(bool significant)
        {
            if (significant)
            {
                return "не нормальное";
            }
            return "нормальное";
        }

        public static string getCorrelationCoefficients(string scaleX, string distrX, string scaleY, string distrY, int sampleCount)
        {
            if (scaleX.Equals("дихотомическая"))
            {
                if (scaleY.Equals("дихотомическая"))
                {
                    return "хи квадрат Пирсона, Фишера, Крамера, Гудмена-Крускала";
                }
                else if (distrY.Equals("нормальное"))
                {
                    if (scaleY.Equals("ранговая"))
                    {
                        return "Рангово-бисериальный";
                    }
                    else if (scaleY.Equals("количественная"))
                    {
                        return "Точечно-бисериальный, бисериальный";
                    }
                }
            }
            else if (scaleX.Equals("ранговая"))
            {
                if (distrX.Equals("нормальное"))
                {
                    if (scaleY.Equals("дихотомическая"))
                    {
                        return "Рангово-бисериальный";
                    }
                    else if (distrY.Equals("нормальное"))
                    {
                        if (scaleY.Equals("ранговая"))
                        {
                            return "тау Кендалла";
                        }
                        else if (scaleY.Equals("количественная")
                            && sampleCount <= SPEARMAN_SIZE)
                        {
                            return "Спирмена";
                        }
                    }
                }
                else if ((sampleCount <= SPEARMAN_SIZE)
                    && scaleY.Equals("ранговая") || scaleY.Equals("количественная"))
                {
                    return "Спирмена";
                }
            }
            else if (scaleX.Equals("количественная"))
            {
                if (distrX.Equals("нормальное"))
                {

                    if (scaleY.Equals("дихотомическая"))
                    {
                        return "Точечно-бисериальный, бисериальный";
                    }
                    else if (distrY.Equals("нормальное"))
                    {
                        if (scaleY.Equals("количественная"))
                        {
                            return "Пирсона";
                        }
                        else if (sampleCount <= SPEARMAN_SIZE && scaleY.Equals("ранговая"))
                        {
                            return "Спирмена";
                        }
                    }
                    else
                    {
                        if (sampleCount <= SPEARMAN_SIZE)
                        {
                            return "Спирмена";
                        }
                    }
                }
            }

            return "не применимы";
        }


        static Random rnd = new Random();

        public static double[] generateValues(string typeScale, string typeDistr, int size)
        {

            List<double> sample = new List<double>(size);
            if (typeScale.Equals("дихотомическая"))
            {
                for (int i = 0; i < size; i++)
                {
                    sample.Add(rnd.Next(2));
                }
            }
            else if (typeScale.Equals("ранговая"))
            {
                if (typeDistr.Equals("нормальное"))
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
            else if (typeScale.Equals("количественная"))
            {
                if (typeDistr.Equals("нормальное"))
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

        public static string getReggressionMethod(List<string> typeScale, string typeMethod, List<double> vs)
        {
            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist =
                Accord.Statistics.Distributions.Univariate.NormalDistribution.Standard;

            Accord.Statistics.Testing.KolmogorovSmirnovTest kstX =
                    new Accord.Statistics.Testing.KolmogorovSmirnovTest(vs.ToArray(), normDist);
            AnalysisClass.getDistributionScale(kstX.Significant);
            switch (typeMethod)
            {
                case "Простая линейная регрессия":
                    if ((typeScale[0].Equals("ранговая") || typeScale[0].Equals("количественная")) && typeScale.Count == 2)
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }
                case "Множественная линейная регрессия":
                    if ((typeScale[0].Equals("ранговая") || typeScale[0].Equals("количественная")) && typeScale.Count > 2 )
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }
                case "Нелинейная регрессия":
                    if ((typeScale[0].Equals("ранговая") || typeScale[0].Equals("количественная")) && typeScale.Count >= 2 && AnalysisClass.getDistributionScale(kstX.Significant) == "нормальное")
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }

                case "Бинарная логистическая регрессия":
                    if ((typeScale[0].Equals("дихотомическая")) && typeScale.Count > 2)
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }
                case "Мультиномиальная логистическая регрессия":
                    if (typeScale[0].Equals("ранговая") && typeScale.Count > 2 && AnalysisClass.getDistributionScale(kstX.Significant) == "нормальное")
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }
                case "Порядковая регрессия":
                    if (typeScale[0].Equals("ранговая") && typeScale.Count > 2 && AnalysisClass.getDistributionScale(kstX.Significant) == "нормальное")
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }
                case "Пробит-анализ":
                    if ((typeScale[0].Equals("дихотомическая")) && typeScale.Count > 2)
                    {
                        return "Метод применим к данным";
                    }
                    else
                    {
                        return "Метод не применим к данным";
                    }
                default:
                    return "Нет";
            }
        }

        public static string getCurrentReggressionMethod(List<string> typeScale, List<double> vs)
        {
            if (typeScale.Count == 2 && !typeScale[0].Equals("дихотомическая"))
            {
                return "Простая линейная регрессия";
            }
            else if (typeScale[0].Equals("дихотомическая") && typeScale.Count > 2)
            {
                return "Пробит-анализ:Бинарная логистическая регрессия";
            }
            else if (typeScale[0].Equals("ранговая") && typeScale.Count > 2)
            {
                return "Порядковая регрессия:Мультиномиальная логистическая регрессия";
            }
            else if ((typeScale[0].Equals("ранговая") || typeScale[0].Equals("количественная")) && typeScale.Count > 2)
            {
                return "Множественная линейная регрессия";
            }
            else if (typeScale[0].Equals("количественная") && typeScale.Count >= 2)
            {
                return "Нелинейная регрессия";
            }
            else
            {
                return "Система не может дать правильного ответа";
            }
        }

    }
}
