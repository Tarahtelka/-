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
    public partial class Analysis : Form
    {
        
        Class1 cl = new Class1();

        newdata data_frm = new newdata();
        List<Double> xVals = new List<Double>();
        List<Double> yVals = new List<Double>();

        public Analysis()
        {
            InitializeComponent();
            clearForm();
            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
            cl.CreateGraph3(zg3, dataGV_data);
        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_frm.save_data(dataGV_data);
        }

        private void doAnalysisBtn_Click(object sender, EventArgs e)
        {
            List<Double> xUniqVals = new List<Double>();
            List<Double> yUniqVals = new List<Double>();

            for (int i = 0; i < dataGV_data.RowCount-1; i++)
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
            volumeTxtBx.Text = (dataGV_data.RowCount-1).ToString();
            xUniqCountTxtBx.Text = xUniqVals.Count.ToString();
            yUniqCountTxtBx.Text = yUniqVals.Count.ToString();
            xSchaleTxtBx.Text = AnalysisClass.getScale(xUniqVals.Count);
            ySchaleTxtBx.Text = AnalysisClass.getScale(yUniqVals.Count);

            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist =
                Accord.Statistics.Distributions.Univariate.NormalDistribution.Standard;

            cl.CreateGraph(zg1, dataGV_data);

            if (!xSchaleTxtBx.Text.Equals("дихотомическая"))
            {
                Accord.Statistics.Testing.KolmogorovSmirnovTest kstX =
                    new Accord.Statistics.Testing.KolmogorovSmirnovTest(xVals.ToArray(), normDist);
                distrXTxtBx.Text = AnalysisClass.getDistributionScale(kstX.Significant);

                meanXTxtBx.Text = MathNet.Numerics.Statistics.Statistics.Mean(xVals).ToString();
                stddevXTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(xVals).ToString();

                skewXTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationSkewness(xVals).ToString();
                kurtXTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationKurtosis(xVals).ToString();

                cl.CreateGraph3(zg3, dataGV_data);
            }

            if (!ySchaleTxtBx.Text.Equals("дихотомическая"))
            {
                Accord.Statistics.Testing.KolmogorovSmirnovTest kstY =
                new Accord.Statistics.Testing.KolmogorovSmirnovTest(yVals.ToArray(), normDist);
                distrYTxtBx.Text = AnalysisClass.getDistributionScale(kstY.Significant);

                meanYTxtBx.Text = MathNet.Numerics.Statistics.Statistics.Mean(yVals).ToString();
                stddevYTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(yVals).ToString();

                skewYTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationSkewness(yVals).ToString();
                kurtYTxtBx.Text = MathNet.Numerics.Statistics.Statistics.PopulationKurtosis(yVals).ToString();

                cl.CreateGraph2(zg2, dataGV_data);
            }

            coefficientsTxtBx.Text = AnalysisClass.getCorrelationCoefficients(
                xSchaleTxtBx.Text, distrXTxtBx.Text, ySchaleTxtBx.Text, distrYTxtBx.Text, dataGV_data.RowCount - 1);
            

            xVals.Clear();
            yVals.Clear();
            xUniqVals.Clear();
            yUniqVals.Clear();
        }

        private void openFD_File_Click(object sender, EventArgs e)
        {
            try
            {
                data_frm.open_file(dataGV_data);
                clearForm();
                очиститьToolStripMenuItem.Enabled = true;
                doAnalysisBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAllForm();
        }

        private void clearAllForm()
        {
            dataGV_data.Rows.Clear();
            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
            cl.CreateGraph3(zg3, dataGV_data);
            clearForm();
        }

        private void clearForm()
        {
            volumeTxtBx.Clear();
            xUniqCountTxtBx.Clear();
            yUniqCountTxtBx.Clear();
            xSchaleTxtBx.Clear();
            ySchaleTxtBx.Clear();
            distrXTxtBx.Clear();
            distrYTxtBx.Clear();
            meanXTxtBx.Clear();
            meanYTxtBx.Clear();
            stddevXTxtBx.Clear();
            stddevYTxtBx.Clear();
            skewXTxtBx.Clear();
            skewYTxtBx.Clear();
            kurtXTxtBx.Clear();
            kurtYTxtBx.Clear();
            coefficientsTxtBx.Clear();
            очиститьToolStripMenuItem.Enabled = false;
            doAnalysisBtn.Enabled = false;
        }

        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
            }
            return dgv_copy;
        }
    }
}
