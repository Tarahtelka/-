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
    public partial class SimpleLinearReg : Form
    {
        public SimpleLinearReg()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        int count_cols, count_rows, temp = 0, number_cols;
        string headText, columnName;

        List<double> values = new List<double>();
        List<double> nvalues = new List<double>();

        double stanDevZav, stanDevNZav, coeffreg, oY, coeffCorel, coeffDeterm, standExsep;
        Plotting plotting = new Plotting();
        private void calcLinerRegress(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                double val1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                double val2 = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                values.Add(val1);
                nvalues.Add(val2);
            }
            stanDevZav = standardDeviation(values.ToArray());
            stanDevNZav = standardDeviation(nvalues.ToArray());
            coeffreg = CoffReg(values.ToArray(), nvalues.ToArray());
            oY = Avg(values.ToArray()) - coeffreg * Avg(nvalues.ToArray());
            coeffCorel = coeffreg * stanDevNZav / stanDevZav;
            coeffDeterm = coeffCorel * coeffCorel;
            standExsep = StanExsep(values.ToArray(), nvalues.ToArray());

            StandartDevZav.Text = Math.Round(stanDevZav, 3).ToString();
            StandrtDevNZav.Text = Math.Round(stanDevNZav, 3).ToString();
            PirsCorr.Text = Math.Round(coeffCorel, 3).ToString();
            koeffReg.Text = Math.Round(coeffreg, 3).ToString();
            Oy.Text = Math.Round(oY, 3).ToString();
            StandrExp.Text = Math.Round(standExsep, 3).ToString();

            plotting.CreateLinerRegGraph(zg2, values, nvalues, coeffreg, oY);

            values.Clear();
            nvalues.Clear();
        }

        private void ExplCorr_Click(object sender, EventArgs e)
        {
            ExplCorrelation explCorrelation = new ExplCorrelation();
            explCorrelation.Show();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandartDevZav.Clear();
            StandrtDevNZav.Clear();
            PirsCorr.Clear(); 
            koeffReg.Clear();
            Oy.Clear();
            StandrExp.Clear();
            dataGridView1.Rows.Clear();
            zg2.GraphPane.CurveList.Clear();
            zg2.GraphPane.GraphObjList.Clear();
            zg2.Refresh();
            panel1.Enabled = false;
            dataGridView1.Columns.Clear();
            CreateFile.CreateFile.numberСolumns = 0;
        }

        private void main_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SimpleLinearReg_Load(object sender, EventArgs e)
        {
            zg2.GraphPane.Title.Text = "Диаграмма рассеяния";
        }

        private void SimpleLinearRegression_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateFile.CreateFile.numberСolumns = 0;
        }

        StreamReader sr, sr2;

        private void openFD_File_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            try
            {
                open_file(dataGridView1);
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                {
                    if (dataGridView1.Columns.Count != 2)
                    {
                        MessageBox.Show("Откройте файл для простой линейной регрессии");
                    }
                    else
                    {
                        StandartDevZav.Clear();
                        StandrtDevNZav.Clear();
                        PirsCorr.Clear();
                        koeffReg.Clear();
                        Oy.Clear();
                        StandrExp.Clear();
                        zg2.GraphPane.CurveList.Clear();
                        zg2.GraphPane.GraphObjList.Clear();
                        zg2.Refresh();

                        panel1.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        public double standardDeviation(double[] arr)
        {
            double avg = Avg(arr);
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] * arr[i];
            }
            double disp = (sum / arr.Length) - avg * avg;
            return Math.Sqrt(disp);
        }
        public double Avg(double[] arr)
        {
            return arr.Sum() / arr.Length;
        }
        public double CoffReg(double[] arr, double[] arr1)
        {
            double avg = Avg(arr);
            double avg1 = Avg(arr1);
            double sum=0 ,sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (arr[i] - avg) * (arr1[i] - avg1);
                sum1 += (arr1[i] - avg1) * (arr1[i] - avg1);
            }
            return sum / sum1;
        
        }
        public double CoffCor(double[] arr, double[] arr1)
        {
            double avg = Avg(arr);
            double avg1 = Avg(arr1);
            double sum = 0, sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (arr[i] - avg) * (arr1[i] - avg1);
                sum1 += ((arr1[i] - avg1) * (arr1[i] - avg1)) * ((arr[i] - avg) * (arr[i] - avg));
            }
            return sum / Math.Sqrt(sum1);

        }
        public double PowStanExsep(double[] arr, double[] arr1)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += (arr[i] - (oY + coeffreg * arr1[i]))* (arr[i] - (oY + coeffreg * arr1[i]));
            }
            double a = arr.Length - 2;
            return sum / (arr.Length - 2);
        }
        public double StanExsep(double[] arr, double[] arr1)
        {
            double sum = 0;
            double avg = Avg(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                sum = (arr1[i] - avg) * (arr1[i] - avg);
            }
            double y = PowStanExsep(arr, arr1);
            return Math.Sqrt(PowStanExsep(arr, arr1)) / sum;
        } 

    }
}
