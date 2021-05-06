using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using ZedGraph;

namespace Ocenka_mer_svyzei
{
    public class Plotting
    {
        public void CreateGraphNormDistr(ZedGraphControl zg1, List<double> val, List<double> valuq)
        {
            GraphPane pane = zg1.GraphPane;

            pane.Title.Text = "Гистограмма нормальности распределения";
            pane.XAxis.Title.Text = "X ";
            pane.YAxis.Title.Text = "Y ";
            double x = 0;
            double xmax;
            double xmin;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            Random rnd = new Random();
            //// Высота столбиков
            xmax = val.Max();
            xmin = val.Min();
            pane.XAxis.Scale.Min = xmin - 1;
            pane.XAxis.Scale.Max = xmax + 1;
            List<double> vs = new List<double>();
            valuq.Sort();
            for (int j = 0; j < valuq.Count; j++)
            {
                for (int i = 0; i < val.Count; i++)
                {
                    if (val[i] == valuq[j])
                    {
                        x++;
                    }
                }
                vs.Add(x);
                x = 0;
            }
            BarItem bar = pane.AddBar("Гистограмма", valuq.ToArray(), vs.ToArray(), Color.Blue);

            // !!! Расстояния между кластерами (группами столбиков) гистограммы = 0.0
            // У нас в кластере только один столбик.
            pane.BarSettings.MinClusterGap = 0.2f;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zg1.AxisChange();

            // Обновляем график
            zg1.Invalidate();
        }

        public void CreateLinerRegGraph(ZedGraphControl zg2, List<double> val, List<double> val1, double b, double a)
        {
            GraphPane pane = zg2.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();
            List<PointPairList> pointPairs = new List<PointPairList>();

            PointPairList list1 = new PointPairList();
            double xmin = val1.Min()-1;
            double xmax = val1.Max()+1;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                // добавим в список точку
                list.Add(x, a+b*x);
            }

            for (int i = 0; i < val.Count; i++)
            {
                list1.Add(val1[i], val[i]);
                pointPairs.Add(list1);
            }

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("lineReg", list, Color.Blue, SymbolType.None);



            LineItem myCurve1 = pane.AddCurve("", list1, Color.Red, SymbolType.Circle);
            myCurve1.Line.IsVisible = false;


            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zg2.AxisChange();

            // Обновляем график
            zg2.Invalidate();
        }

        public void CreateMultLinerRegGraph(ZedGraphControl zg3, List<double> val, List<double> val1, double b, double a)
        {
            GraphPane pane = zg3.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();


            // Создадим список точек
            PointPairList list = new PointPairList();
            List<PointPairList> pointPairs = new List<PointPairList>();

            PointPairList list1 = new PointPairList();
            double xmin = val1.Min() - 1;
            double xmax = val1.Max() + 1;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                // добавим в список точку
                list.Add(x, a + b * x);
            }

            for (int i = 0; i < val.Count; i++)
            {
                list1.Add(val1[i], val[i]);
                pointPairs.Add(list1);
            }

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("lineReg", list, Color.Blue, SymbolType.None);



            LineItem myCurve1 = pane.AddCurve("", list1, Color.Red, SymbolType.Circle);
            myCurve1.Line.IsVisible = false;


            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zg3.AxisChange();

            // Обновляем график
            zg3.Invalidate();
        }
    }
}
