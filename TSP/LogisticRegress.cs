using Accord.Statistics.Analysis;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Linear;
using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    public partial class LogisticRegress : Form
    {
        public LogisticRegress()
        {
            InitializeComponent();
        }

        private void openFD_File_Click(object sender, EventArgs e)
        {

            try
            {
                open_file(dataGridView1);
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                {

                    Run.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private MultipleLinearRegressionAnalysis mlr;
        string headText, columnName;
        int count_cols, count_rows;
        StreamReader sr, sr2;

        double[][] inputs;
        double[] outputs;

        private void LogisticRegress_Load(object sender, EventArgs e)
        {

        }

        public void open_file(DataGridView dg1)
        {
            count_cols = 0;
            // считывание данных из файла
            DataGridView dg = dg1;

            try
            {
                openFD.Filter = "Text Files (*.txt)|*.txt|" + "XML Files (*.xml)|*.xml|" + "EXCEL Files (*.xls)|*.xls|" + "CSV Files (*.csv)|*.csv";
                openFD.RestoreDirectory = true;

                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    if (CreateFile.CreateFile.numberСolumns > 0)
                    {
                        dataGridView1.Columns.Remove("Zav");
                        for (int s = 1; s < CreateFile.CreateFile.numberСolumns; s++)
                        {
                            dataGridView1.Columns.Remove("NZav" + s.ToString());
                        }
                        CreateFile.CreateFile.numberСolumns = 0;
                    }
                    Stream myStream = openFD.OpenFile();
                    if (myStream != null)
                    {
                        if (openFD.FileName.Substring((openFD.FileName.Length - 3), 3).CompareTo("xml") == 0)
                        {
                            // считывание данных из файла xml
                            try
                            {
                                DataSet ds = new DataSet();
                                ds.ReadXml(openFD.FileName);
                                ds.ReadXmlSchema(openFD.FileName.Substring(0, (openFD.FileName.Length - 4)) + ".xsd");

                                count_cols = ds.Tables[0].Columns.Count;
                                CreateFile.CreateFile.numberСolumns = count_cols;
                                headText = "Зависимая переменная";
                                columnName = "Zav";
                                dataGridView1.Columns.Add(columnName, headText);
                                for (int k = 1; k < count_cols; k++)
                                {
                                    headText = "Независимая переменная №" + k.ToString();
                                    columnName = "NZav" + k.ToString();
                                    dataGridView1.Columns.Add(columnName, headText);
                                }
                                // dg.Columns.Clear();
                                // dg.DataSource = ds.Tables[0];
                                dg.Rows.Clear();
                                foreach (DataRow row in ds.Tables[0].Rows)
                                {
                                    DataGridViewRow rw = new DataGridViewRow();
                                    rw.Cells.AddRange();
                                    dg.Rows.Add(row.ItemArray);
                                }
                                myStream.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка файла!", "Ошибка");
                            }
                        }
                        else if (openFD.FileName.Substring((openFD.FileName.Length - 3), 3).CompareTo("txt") == 0)
                        {
                            //считывание данных из файла или *.txt
                            try
                            {
                                string[] row; // одна строка данных
                                              // подклюдение файла данных и считывание информации из него
                                sr = new StreamReader(openFD.FileName, Encoding.Default);
                                sr2 = new StreamReader(openFD.FileName, Encoding.Default);
                                string input;
                                int i = 0;
                                headText = "Зависимая переменная";
                                columnName = "Zav";
                                dataGridView1.Columns.Add(columnName, headText);
                                count_cols = sr.ReadLine().Split(' ').Length - 1;
                                for (int k = 1; k < count_cols; k++)
                                {
                                    headText = "Независимая переменная №" + k.ToString();
                                    columnName = "NZav" + k.ToString();
                                    dataGridView1.Columns.Add(columnName, headText);
                                }
                                CreateFile.CreateFile.numberСolumns = count_cols;
                                while ((input = sr.ReadLine()) != null) // считывание информации из файла по-строчно
                                {
                                    i++;
                                }
                                count_rows = i + 1;
                                i = dg.RowCount;
                                int j = 0;
                                while (count_rows < i)
                                {
                                    dg.Rows.RemoveAt(j);
                                    j++;
                                    i--;
                                }
                                if (count_rows > i)
                                {
                                    dg.Rows.Add(count_rows - i);
                                }
                                i = 0;
                                while ((input = sr2.ReadLine()) != null) // считывание информации из файла по-строчно
                                {
                                    row = input.Trim().Split(' '); // разделение строки на отдельные части
                                    dg.Rows[i].SetValues(row);
                                    i++;
                                }
                                sr.Close(); //закрытие файла после считывания у него информации
                                myStream.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (openFD.FileName.Substring((openFD.FileName.Length - 3), 3).CompareTo("xls") == 0)
                        {

                            try
                            {

                                ExcelFile ef2 = new ExcelFile();
                                ef2.LoadXls(openFD.FileName);
                                //DataSet ds = new DataSet();
                                //DataTable Table1 = new DataTable();
                                //ds.Tables.Add(Table1);
                                myStream.Close();
                                foreach (ExcelRow rw in ef2.Worksheets[0].Rows)
                                {
                                    count_cols = rw.AllocatedCells.Count;
                                }

                                string[] outp = new string[count_cols];

                                CreateFile.CreateFile.numberСolumns = count_cols;
                                headText = "Зависимая переменная";
                                columnName = "Zav";
                                dataGridView1.Columns.Add(columnName, headText);
                                for (int k = 1; k < count_cols; k++)
                                {
                                    headText = "Независимая переменная №" + k.ToString();
                                    columnName = "NZav" + k.ToString();
                                    dataGridView1.Columns.Add(columnName, headText);
                                }

                                //ds.Tables[0].Columns.Add("X");
                                //ds.Tables[0].Columns.Add("Y");
                                //dg.Columns.Clear();
                                int j = 0;
                                //string ssdv = ef2.Worksheets[0].Rows;
                                foreach (ExcelRow rw in ef2.Worksheets[0].Rows)
                                {

                                    int i = 0;
                                    foreach (ExcelCell cl in rw.AllocatedCells)
                                    {
                                        if (cl.Value != null)
                                            outp[i] = cl.Value.ToString() + " ";
                                        if (cl.Value == null)
                                            outp[i] = "0 ";
                                        i++;
                                    }
                                    if (j > 0)
                                        dg.Rows.Add(outp);
                                    j++;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (openFD.FileName.Substring((openFD.FileName.Length - 3), 3).CompareTo("csv") == 0)
                        {
                            try
                            {
                                var inputArray = new List<string>();

                                using (StreamReader streamReader = new StreamReader(openFD.FileName))
                                {
                                    inputArray = streamReader.ReadToEnd().Replace("\r", "").Split('\n').Select(s => s.Trim()).ToList();
                                    inputArray.RemoveAt(0);
                                }
                                myStream.Close();

                                count_cols = inputArray[0].Split(';').Length;

                                string[] outp = new string[count_cols];

                                CreateFile.CreateFile.numberСolumns = count_cols;
                                headText = "Зависимая переменная";
                                columnName = "Zav";
                                dataGridView1.Columns.Add(columnName, headText);
                                for (int k = 1; k < count_cols; k++)
                                {
                                    headText = "Независимая переменная №" + k.ToString();
                                    columnName = "NZav" + k.ToString();
                                    dataGridView1.Columns.Add(columnName, headText);
                                }

                                int j = 0;
                                foreach (var rw in inputArray)
                                {
                                    int i = 0;
                                    var temp = rw.Split(';');
                                    foreach (var cl in temp)
                                    {
                                        if (!string.IsNullOrEmpty(cl))
                                            outp[i] = cl + " ";
                                        if (string.IsNullOrEmpty(cl))
                                            outp[i] = "0 ";
                                        i++;
                                    }
                                    dg.Rows.Add(outp);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неизвестный формат файла!");
                        }
                    }
                }
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Run.Enabled = true;
            dgvLogisticCoefficients.ClearSelection();
            tbLogLikelihood.Text = "";
            tbDeviance.Text = "";
            tbChiSquare.Text = "";
            tbPValue.Text = "";
            checkBox1.Checked = false;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            // Finishes and save any pending changes to the given data
            dataGridView1.EndEdit();
            double[][] inputs = new double[dataGridView1.RowCount - 1][];
            double[] outputs = new double[dataGridView1.RowCount - 1];
            List<double> vs = new List<double>();

            for (int j = 0; j < dataGridView1.RowCount - 1; j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                {
                    vs.Add(Convert.ToDouble(dataGridView1.Rows[j].Cells[i + 1].Value));
                }
                inputs[j] = vs.ToArray();
                vs.Clear();
            }
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                outputs[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
            }

            var lra = new LogisticRegressionAnalysis()
            {
                Inputs = GetIndependentNames(),
                Output = GetDependentName()
            };

            //Compute the Logistic Regression Analysis
            LogisticRegression lr = lra.Learn(inputs, outputs);

            //Populates coefficient overview with analysis data
            dgvLogisticCoefficients.DataSource = lra.Coefficients;

            //Populate details about the fitted model
            tbChiSquare.Text = lra.ChiSquare.Statistic.ToString("N5");
            tbPValue.Text = lra.ChiSquare.PValue.ToString("N5");
            checkBox1.Checked = lra.ChiSquare.Significant;
            tbDeviance.Text = lra.Deviance.ToString("N5");
            tbLogLikelihood.Text = lra.LogLikelihood.ToString("N5");

            ////Нужно считать названия переменных
            //this.mlr = new MultipleLinearRegressionAnalysis(intercept: true)
            //{
            //    Inputs = GetIndependentNames(),
            //    Output = GetDependentName()
            //};

            //// Compute the Linear Regression Analysis
            //MultipleLinearRegression reg = mlr.Learn(inputs, outputs);

            //dgvLinearCoefficients.DataSource = mlr.Coefficients;
            //dgvRegressionAnova.DataSource = mlr.Table;

        }

        private string GetDependentName()
        {
            return "Зависимая переменная";
        }

        private string[] GetIndependentNames()
        {
            if (dataGridView1.ColumnCount < 0)
            {
                throw new Exception("Логистчисческая выход меня независимыж");
            }

            string[] result = new string[dataGridView1.ColumnCount - 1];

            for (int i = 0; i < dataGridView1.ColumnCount-1; i++)
            {
                result[i] = $"Независимая переменная №{i + 1}";
            }

            return result;
        }

    }
}
