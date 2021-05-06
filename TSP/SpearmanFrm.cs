using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    public partial class SpearmanFrm : Form
    {
        Class1 cl = new Class1();

        newdata data_frm = new newdata();
        List<Double> xVals = new List<Double>();
        List<Double> yVals = new List<Double>();

        public SpearmanFrm()
        {
            InitializeComponent();
            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
            cl.CreateGraph3(zg3, dataGV_data);
            calculateBtn.Enabled = false;
            очиститьToolStripMenuItem.Enabled = false;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            List<Double> xUniqVals = new List<Double>();
            List<Double> yUniqVals = new List<Double>();

            for (int i = 0; i < dataGV_data.RowCount - 1; i++)
            {
                Double val1 = Convert.ToDouble(dataGV_data.Rows[i].Cells[0].Value);
                Double val2 = Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                if (!xUniqVals.Contains(val1))
                {
                    xUniqVals.Add(val1);
                }
                if (!yUniqVals.Contains(val2))
                {
                    yUniqVals.Add(val2);
                }
                xVals.Add(val1);
                yVals.Add(val2);
            }
            volumeTxtBx.Text = (dataGV_data.RowCount - 1).ToString();
            xUniqCountTxtBx.Text = xUniqVals.Count.ToString();
            yUniqCountTxtBx.Text = yUniqVals.Count.ToString();
            xSchaleTxtBx.Text = AnalysisClass.getScale(xUniqVals.Count);
            ySchaleTxtBx.Text = AnalysisClass.getScale(yUniqVals.Count);

            meanXTxtBx.Text = MathNet.Numerics.Statistics.Statistics.Mean(xVals).ToString();
            stddevXTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(xVals).ToString();

            meanYTxtBx.Text = MathNet.Numerics.Statistics.Statistics.Mean(yVals).ToString();
            stddevYTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(yVals).ToString();

            Double corrVal = MathNet.Numerics.Statistics.Correlation.Spearman(xVals, yVals);
            corrValTxtBx.Text = corrVal.ToString();
            int freedomDegree = xVals.Count - 2;
            if (freedomDegree >= 5 && freedomDegree <= 30)
            {
                critValTxtBx.Text = CorrelationUtils.getSpearmanCriticalValue(freedomDegree, float.Parse("0,05")).ToString();
                isCorrelatedTxtBx.Text = CorrelationUtils.getSpearmanSignificant(freedomDegree, corrVal);
            }
            else
            {
                critValTxtBx.Text = "не рассчитано";
                isCorrelatedTxtBx.Text = CorrelationUtils.getSpearmanSignificant(freedomDegree, corrVal);
            }

            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
            cl.CreateGraph3(zg3, dataGV_data);

            xVals.Clear();
            yVals.Clear();
            xUniqVals.Clear();
            yUniqVals.Clear();
        }

        private void openFD_File_Click(object sender, EventArgs e)
        {
            clearForm();
            data_frm.open_file(dataGV_data);
            calculateBtn.Enabled = true;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearForm();
            calculateBtn.Enabled = false;
            очиститьToolStripMenuItem.Enabled = false;
        }

        private void clearForm()
        {
            dataGV_data.Rows.Clear();
            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
            cl.CreateGraph3(zg3, dataGV_data);
            xVals.Clear();
            yVals.Clear();
            volumeTxtBx.Clear();
            xUniqCountTxtBx.Clear();
            yUniqCountTxtBx.Clear();
            xSchaleTxtBx.Clear();
            ySchaleTxtBx.Clear();
            meanXTxtBx.Clear();
            meanYTxtBx.Clear();
            stddevXTxtBx.Clear();
            stddevYTxtBx.Clear();
            corrValTxtBx.Clear();
            critValTxtBx.Clear();
            isCorrelatedTxtBx.Clear();
            calculateBtn.Enabled = false;
        }
    }
}
