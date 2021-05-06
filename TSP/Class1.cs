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
    class Class1
    {
        public void CreateGraph(ZedGraphControl zgc, DataGridView dg)
        {
            DataGridView dataGV_data = dg;
            try
            {
                GraphPane myPane = zgc.GraphPane;
                double x = 0;
                double y = 0;
                double ymax = 0;
                double ymin = 0;
                double xmax = 0;
                double xmin = 0;
                myPane.Title.Text = "Диаграмма рассеивания";
                myPane.XAxis.Title.Text = "X ";
                myPane.YAxis.Title.Text = "Y ";
                PointPairList list = new PointPairList();
                for (int i = 0; i < dataGV_data.RowCount - 1; i++)
                {
                    y = Convert.ToDouble(dataGV_data.Rows[i].Cells[0].Value);
                    if (ymax < y)
                        ymax = y;
                    if (ymin > y)
                        ymin = y;
                    x = Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                    if (xmax < x)
                        xmax = x;
                    if (xmin > x)
                        xmin = x;
                    list.Add(x, y);
                }

                LineItem myCurve = myPane.AddCurve("", list, Color.Blue, SymbolType.Diamond);

                // У кривой линия будет невидимой
                myCurve.Line.IsVisible = false;

                // Цвет заполнения отметок (ромбиков) - колубой
                myCurve.Symbol.Fill.Color = Color.Blue;

                // Тип заполнения - сплошная заливка
                myCurve.Symbol.Fill.Type = FillType.Solid;

                // Размер ромбиков
                myCurve.Symbol.Size = 7;

                // Устанавливаем интересующий нас интервал по оси X
                myPane.XAxis.Scale.Min = xmin - 1;
                myPane.XAxis.Scale.Max = xmax + 1;

                // Устанавливаем интересующий нас интервал по оси Y
                myPane.YAxis.Scale.Min = ymin - 1;
                myPane.YAxis.Scale.Max = ymax + 1;

                // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
                // В противном случае на рисунке будет показана только часть графика, 
                // которая умещается в интервалы по осям, установленные по умолчанию
                zgc.AxisChange();

                // Обновляем график
                zgc.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CreateGraph2(ZedGraphControl zg2, DataGridView dg)
        {
            DataGridView dataGV_data = dg;
            GraphPane pane = zg2.GraphPane;
            pane.Title.Text = "Гистограмма нормальности распределения Y";
            pane.XAxis.Title.Text = "X ";
            pane.YAxis.Title.Text = "Y ";
            double x = 0;
            double xmax;
            double xmin;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            Random rnd = new Random();
            //// Высота столбиков
            int count;
            count = dataGV_data.RowCount - 1;
            double[] ryd = new double[count];
            double trash;
            xmin = Convert.ToDouble(dataGV_data.Rows[0].Cells[1].Value);
            xmax = Convert.ToDouble(dataGV_data.Rows[0].Cells[1].Value);
            for (int i = 0; i < count; i++)
            {
                x = Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                if (xmax < x)
                    xmax = x;

                if (xmin > x)
                    xmin = x;
                ryd[i] = x;
            }
            pane.XAxis.Scale.Min = xmin - 1;
            pane.XAxis.Scale.Max = xmax + 1;
            double d;
            d = (xmax - xmin) / 8;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                    if (ryd[j] > ryd[j + 1])
                    {
                        trash = ryd[j];
                        ryd[j] = ryd[j + 1];
                        ryd[j + 1] = trash;
                    }
            }
            int m = 0;
            double[] values = new double[count];
            for (int i = 0; i < count; i++)
            {
                m = 0;
                for (int j = 0; j < count; j++)
                {

                    if (xmin <= Convert.ToDouble(ryd[j].ToString()) && Convert.ToDouble(ryd[j].ToString()) <= (xmin + d))
                    {
                        m++;
                    }
                }
                xmin += d;
                values[i] = m / (d * count);
            }

            BarItem bar = pane.AddBar("Гистограмма", ryd, values, Color.Blue);

            // !!! Расстояния между кластерами (группами столбиков) гистограммы = 0.0
            // У нас в кластере только один столбик.
            pane.BarSettings.MinClusterGap = 0.0f;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zg2.AxisChange();

            // Обновляем график
            zg2.Invalidate();
        }



        public void CreateGraph3(ZedGraphControl zg2, DataGridView dg)
        {
            DataGridView dataGV_data = dg;
            GraphPane pane = zg2.GraphPane;
            pane.Title.Text = "Гистограмма нормальности распределения X";
            pane.XAxis.Title.Text = "X ";
            pane.YAxis.Title.Text = "Y ";
            double x = 0;
            double xmax;
            double xmin;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            Random rnd = new Random();
            //// Высота столбиков
            int count;
            count = dataGV_data.RowCount - 1;
            double[] ryd = new double[count];
            double trash;
            xmin = Convert.ToDouble(dataGV_data.Rows[0].Cells[0].Value);
            xmax = Convert.ToDouble(dataGV_data.Rows[0].Cells[0].Value);
            for (int i = 0; i < count; i++)
            {
                x = Convert.ToDouble(dataGV_data.Rows[i].Cells[0].Value);
                if (xmax < x)
                    xmax = x;

                if (xmin > x)
                    xmin = x;
                ryd[i] = x;
            }
            pane.XAxis.Scale.Min = xmin - 1;
            pane.XAxis.Scale.Max = xmax + 1;
            double d;
            d = (xmax - xmin) / 8;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                    if (ryd[j] > ryd[j + 1])
                    {
                        trash = ryd[j];
                        ryd[j] = ryd[j + 1];
                        ryd[j + 1] = trash;
                    }
            }
            int m = 0;
            double[] values = new double[count];
            for (int i = 0; i < count; i++)
            {
                m = 0;
                for (int j = 0; j < count; j++)
                {

                    if (xmin <= Convert.ToDouble(ryd[j].ToString()) && Convert.ToDouble(ryd[j].ToString()) <= (xmin + d))
                    {
                        m++;
                    }
                }
                xmin += d;
                values[i] = m / (d * count);
            }

            BarItem bar = pane.AddBar("Гистограмма", ryd, values, Color.Blue);

            // !!! Расстояния между кластерами (группами столбиков) гистограммы = 0.0
            // У нас в кластере только один столбик.
            pane.BarSettings.MinClusterGap = 0.0f;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zg2.AxisChange();

            // Обновляем график
            zg2.Invalidate();
        }
    }
}
