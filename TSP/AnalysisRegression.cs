using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    public partial class AnalysisRegression : Form
    {

        int count_cols, count_rows, temp = 0, number_cols;
        string headText, columnName;
        StreamReader sr, sr2;

        List<double> values = new List<double>();
        List<double> valuesUQ = new List<double>();
        List<double> nZvalue = new List<double>();

        List<string> Ztype = new List<string>();


        Plotting plotting = new Plotting();

        private void AnalysisRegression_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateFile.CreateFile.numberСolumns = 0;
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    double val1 = Convert.ToDouble(dataGridView1.Rows[j].Cells[i].Value);
                    if (!nZvalue.Contains(val1))
                    {
                        nZvalue.Add(val1);
                    }
                }
                Ztype.Add(AnalysisClass.getScale(nZvalue.Count));
                nZvalue.Clear();
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double val1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                nZvalue.Add(val1);
            }
            resTypeReg.Text = AnalysisClass.getReggressionMethod(Ztype, comboBox2.Text, nZvalue);
            nZvalue.Clear();

        }*/

        private void AnalizMetod_Click(object sender, EventArgs e)
        {
            Ztype.Clear();
            nZvalue.Clear();
            if ((dataGridView1.Columns.Count-1) * 3 <= dataGridView1.RowCount)
            {


                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        double val1 = Convert.ToDouble(dataGridView1.Rows[j].Cells[i].Value);
                        if (!nZvalue.Contains(val1))
                        {
                            nZvalue.Add(val1);
                        }
                    }
                    Ztype.Add(AnalysisClass.getScale(nZvalue.Count));
                    nZvalue.Clear();
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    double val1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    nZvalue.Add(val1);
                }
                string[] words = AnalysisClass.getCurrentReggressionMethod(Ztype, nZvalue).Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                richTextBox1.Text = string.Join(Environment.NewLine, words);
                nZvalue.Clear();
            }
            else
            {
                richTextBox1.Text = "Выборка слишком мала для точного анализа.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveRegression saveRegression = new SaveRegression();

            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                string NumberOfVariable = "", NumberOfUqVariable = "", TypeOfScale = "", DistType = "", AGV = "", Slope = "", Mechanics = "", StandardDeviation = "";
                List<double> listtemp = new List<double>();
                int temp = 0;
                Accord.Statistics.Distributions.Univariate.NormalDistribution normDist =
               Accord.Statistics.Distributions.Univariate.NormalDistribution.Standard;
                double[,] matr = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        matr[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        if (!listtemp.Contains(matr[i, j]))
                        {
                            temp++;
                        }
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            listtemp.Add(matr[i, j]);
                        }
                    }

                    TypeOfScale += AnalysisClass.getScale(temp) + "!";
                    NumberOfUqVariable += temp.ToString() + "!";
                    NumberOfVariable += listtemp.Count().ToString() + "!";

                    if (AnalysisClass.getScale(temp) != "дихотомическая")
                    {
                        Accord.Statistics.Testing.KolmogorovSmirnovTest kstX =
                            new Accord.Statistics.Testing.KolmogorovSmirnovTest(listtemp.ToArray(), normDist);
                        DistType += AnalysisClass.getDistributionScale(kstX.Significant) + "!";
                        AGV += Math.Round(MathNet.Numerics.Statistics.Statistics.Mean(listtemp), 3).ToString() + "!";
                        StandardDeviation += Math.Round(MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(listtemp), 3).ToString() + "!";
                        Mechanics += Math.Round(MathNet.Numerics.Statistics.Statistics.PopulationSkewness(listtemp), 3).ToString() + "!";
                        Slope += Math.Round(MathNet.Numerics.Statistics.Statistics.PopulationKurtosis(listtemp), 3).ToString() + "!";
                    }
                    else
                    {
                        DistType += "Нет!";
                        AGV += "Нет!";
                        StandardDeviation += "Нет!";
                        Mechanics += "Нет!";
                        Slope += "Нет!";
                    }
                    temp = 0;
                    listtemp.Clear();
                }

                DateRegression.TypeMethod = richTextBox1.Text;
                DateRegression.NumberOfScale = dataGridView1.ColumnCount;
                DateRegression.NumberOfVariable = NumberOfVariable;
                DateRegression.NumberOfUqVariable = NumberOfUqVariable;
                DateRegression.TypeOfScale = TypeOfScale;
                DateRegression.DistType = DistType;
                DateRegression.StandardDeviation = StandardDeviation;
                DateRegression.Mechanics = Mechanics;
                DateRegression.AGV = AGV;
                DateRegression.Slope = Slope;

                saveRegression.Show();
            }
            else
            {
                MessageBox.Show("Сначало нужно нажать кнопку 'Предложить метод исследования'");
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Numberofvalues.Clear();
            numberuniquevalues.Clear();
            scaletype.Clear();
            TypeDistr.Clear();
            avg.Clear();
            standarddeviation.Clear();
            skewness.Clear();
            piko.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            zg1.GraphPane.CurveList.Clear();
            zg1.GraphPane.GraphObjList.Clear();
            zg1.Refresh();
            panel1.Enabled = false;
            CreateFile.CreateFile.numberСolumns = 0;
        }

        private void variableanalysisbutton_Click(object sender, EventArgs e)
        {
            clear();
            if (comboBox1.Text.Equals("Зависимая переменная"))
            {
                number_cols = 0;
            }
            else
            {
                string resultString = string.Join(string.Empty, Regex.Matches(comboBox1.Text, @"\d+").OfType<Match>().Select(m => m.Value));
                int.TryParse(resultString, out number_cols);
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double val1 = Convert.ToDouble(dataGridView1.Rows[i].Cells[number_cols].Value);

                if (!valuesUQ.Contains(val1))
                {
                    valuesUQ.Add(val1);
                }
                values.Add(val1);
            }
            Numberofvalues.Text = values.Count.ToString();
            numberuniquevalues.Text = valuesUQ.Count.ToString();
            scaletype.Text = AnalysisClass.getScale(valuesUQ.Count);
            
            

            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist =
                Accord.Statistics.Distributions.Univariate.NormalDistribution.Standard;


            if (!scaletype.Text.Equals("дихотомическая"))
            {
                Accord.Statistics.Testing.KolmogorovSmirnovTest kstX =
                    new Accord.Statistics.Testing.KolmogorovSmirnovTest(values.ToArray(), normDist);
                TypeDistr.Text = AnalysisClass.getDistributionScale(kstX.Significant);
                avg.Text = Math.Round(MathNet.Numerics.Statistics.Statistics.Mean(values), 3).ToString();
                standarddeviation.Text = Math.Round(MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(values), 3).ToString();
                skewness.Text = Math.Round(MathNet.Numerics.Statistics.Statistics.PopulationSkewness(values), 3).ToString();
                piko.Text = Math.Round(MathNet.Numerics.Statistics.Statistics.PopulationKurtosis(values), 3).ToString();
                plotting.CreateGraphNormDistr(zg1, values, valuesUQ);
            }
            else
            {
                TypeDistr.Text = "Невозможно определить определить";
                avg.Text = "Невозможно определить определить";
                standarddeviation.Text = "Невозможно определить определить";
                skewness.Text = "Невозможно определить определить";
                piko.Text = "Невозможно определить определить";
                zg1.GraphPane.CurveList.Clear();
                zg1.GraphPane.GraphObjList.Clear();
                zg1.Refresh();
            }

        }

        public AnalysisRegression()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        public void clear()
        {
            Numberofvalues.Clear();
            numberuniquevalues.Clear();
            scaletype.Clear();
            TypeDistr.Clear();
            avg.Clear();
            standarddeviation.Clear();
            skewness.Clear();
            piko.Clear();
            values.Clear();
            valuesUQ.Clear();
            richTextBox1.Clear();
        }

        private void openFD_File_Click(object sender, EventArgs e)
        {
            
            try
            {
                open_file(dataGridView1);
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                {
                    if (comboBox1.Items.Count == 0)
                    {
                        comboBox1.Items.Add("Зависимая переменная");
                    }
                    temp = comboBox1.Items.Count - 1;
                    for (int i = 1; i <= temp; i++)
                    {
                        comboBox1.Items.Remove("Независимая переменная №" + i.ToString());
                    }
                    for (int i = 1; i < CreateFile.CreateFile.numberСolumns; i++)
                    {
                        headText = "Независимая переменная №" + i.ToString();
                        comboBox1.Items.Add(headText);
                    }
                    temp = 0;
                    panel1.Enabled = true;

                    richTextBox1.Clear();
                    Numberofvalues.Clear();
                    numberuniquevalues.Clear();
                    scaletype.Clear();
                    TypeDistr.Clear();
                    avg.Clear();
                    standarddeviation.Clear();
                    skewness.Clear();
                    piko.Clear();                
                    zg1.GraphPane.CurveList.Clear();
                    zg1.GraphPane.GraphObjList.Clear();
                    zg1.Refresh();
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
    }
}
