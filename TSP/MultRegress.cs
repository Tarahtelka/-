using Accord.Statistics.Models.Regression.Linear;
using GemBox.Spreadsheet;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using CsvHelper;
using System.Collections.Generic;

namespace Ocenka_mer_svyzei
{
    public partial class MultRegress : Form
    {
        public MultRegress()
        {
            InitializeComponent();
        }
        StringBuilder stringBuilder = new StringBuilder();

        private void openFD_File_Click(object sender, EventArgs e)
        {

            try
            {
                open_file(dataGridView1);
                if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
                {
                    if (dataGridView1.Columns.Count <= 2)
                    {
                        MessageBox.Show("Проверьте правильность ввода");
                    }
                    else
                    {
                        panel1.Enabled = true;

                        richTextBox1.Clear();
                        zg3.GraphPane.CurveList.Clear();
                        zg3.GraphPane.GraphObjList.Clear();
                        zg3.Refresh();
                        CreateFile.CreateFile.numberСolumns = 0;
                        button2.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string headText, columnName;
        int count_cols, count_rows;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 2)
            {
                if (dataGridView1.Columns.Count + 1 <= dataGridView1.RowCount)
                { 
                    richTextBox1.Clear();

                    var a = new MultipleLinearRegression();
                    selectComboBox.Items.Clear();
                    double[,] nzav = new double[dataGridView1.RowCount, dataGridView1.ColumnCount - 1];
                    double[] zav = new double[dataGridView1.RowCount];
                    double[,] matr = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
                    double[,] allvaluse = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        matr[i, 0] = 1;
                    }
                    for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            nzav[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j + 1].Value);
                        }
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        zav[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    }
                    for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            matr[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        }
                    }
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            allvaluse[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        }
                    }

                    //Коэф регресси
                    var martTransp = TranspMatr(matr);

                    var martTranspAndmart = Multiply_matrix(martTransp, matr);

                    var martTranspAndzav = Multiply_matrix(martTransp, zav);

                    var matrInvers = Invers(martTranspAndmart);

                    var result = Multiply_matrix(matrInvers, martTranspAndzav);

                    richTextBox1.Text = GetResult(result);

                    DateRegression.CoefRef = result;
                    DateRegression.ValOY = zav;
                    DateRegression.ValOx = nzav;

                    //Парные коэффициенты корреляции
                    var pairRegCor = GetPairsCorel(allvaluse);

                    richTextBox1.Text += GetResultPairCoefRegres(pairRegCor);

                    //Коэфицинет детерминации
                    var determ = GetDeterm(zav, nzav, result);

                    richTextBox1.Text += GetResultNormCoeffDeterm(determ);

                    //Cкорректированный коэффициент детерминации
                    var fixDeterm = GetFixDeterm(determ, allvaluse);

                    richTextBox1.Text += GetResultFixCoeffDeterm(fixDeterm);

                    //Cтандартная ошибка для оценки Y
                    var exp = GetExp(zav, nzav, result);

                    richTextBox1.Text += GetResultExp(exp);

                    //Фишер для всего уравнения
                    var fishAll = GetAllFish(allvaluse, determ);

                    richTextBox1.Text += GetResultAllFisher(fishAll[0], fishAll[1]);

                    //Модель регрессии в стандартном масштабе.
                    var coeffStandartn = GetRegreCoefStan(pairRegCor);

                    //Частные критерии фишера
                    var curretfish = GetCurrnetFish(determ, coeffStandartn, pairRegCor, allvaluse);

                    richTextBox1.Text += GetResultCurrentCoeffFish(curretfish);
                    string s = "";
                    for (int i = 1; i < dataGridView1.Columns.Count; i++)
                    {
                        s = "Зависмая переменная|Независимая переменная №" + i.ToString();
                        selectComboBox.Items.Add(s);
                    }
                    button2.Enabled = true;
                    selectComboBox.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("Загрузите файл, в котором больше выборка");
                }
            }
            else
            {
                MessageBox.Show("Загрузите файл, в котором больше 2 значений.");
            }
        }

        public string GetGetAllFishTable(string significan, double v1, double v2)
        {
            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double significance = double.Parse(ComboBox.Text);
            Thread.CurrentThread.CurrentCulture = temp_culture;
            if (significance == 5)
            {
                significance = 0.05;
            }
            if (significance == 1)
            {
                significance = 0.1;
            }

            string temp = "";
            if (v1 >= 9)
            {
                v1 = 8;
            }
            if (v2 == 9)
            {
                v2 = 8;
            }
            if (v2 == 11)
            {
                v2 = 10;
            }
            if (v2 == 13)
            {
                v2 = 12;
            }
            if (v2 == 15)
            {
                v2 = 14;
            }
            if (v2 == 17)
            {
                v2 = 16;
            }
            if (v2 == 19)
            {
                v2 = 18;
            }
            if (v2 >= 21 && v2 < 25)
            {
                v2 = 20;
            }
            if (v2 >= 26 && v2 < 30)
            {
                v2 = 25;
            }
            if (v2 >= 31 && v2 < 40)
            {
                v2 = 30;
            }
            if (v2 >= 41 && v2 < 60)
            {
                v2 = 40;
            }
            if (v2 >= 61 && v2 < 100)
            {
                v2 = 60;

            }
            if (v2 > 100)
            {
                v2 = 100;
            }
            SqlConnection sqlConnection;

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Regress.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;

            SqlCommand sqlCommand = new SqlCommand("Select * From [Fisher] WHERE Significance = @Significance and v1 = @v1 and v2 = @v2", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Significance", significance);
            sqlCommand.Parameters.AddWithValue("@v1", v1);
            sqlCommand.Parameters.AddWithValue("@v2", v2);

            sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                temp = sqlDataReader["val"].ToString();

            }
            sqlConnection.Close();
            
            return temp;
        }

        public double[,] GetRegreCoefStan(double[,] coeffCorel)
        {
            double[,] rightSide = new double[coeffCorel.GetLength(0) - 1, 1];
            double[,] matrix = new double[coeffCorel.GetLength(0) - 1, coeffCorel.GetLength(0) - 1];
            for (int i = 0; i < coeffCorel.GetLength(0) - 1; i++)
            {
                rightSide[i, 0] = coeffCorel[0, i + 1];
            }
            for (int j = 0; j < coeffCorel.GetLength(0) - 1; j++)
            {
                for (int i = 0; i < coeffCorel.GetLength(0) - 1; i++)
                {
                    matrix[i, j] = coeffCorel[i + 1, j + 1];
                }
            }
            double[,] x = Accord.Math.Matrix.Solve(matrix, rightSide, leastSquares: true);
            return x;   
        }

        public double[] GetCurrnetFish(double determ, double[,] coeffStandartn, double[,] pairRegCor, double[,] allval)
        {
            double[] coefDetemp = new double[coeffStandartn.GetLength(0)];

            for (int i = 0; i < coefDetemp.GetLength(0); i++)
            {
                coefDetemp[i] = determ - coeffStandartn[i, 0] * pairRegCor[0,i + 1];
            }
            double[] result = new double[coefDetemp.Count()+1];
            double temp1 = allval.GetLength(0) - (allval.GetLength(1) - 1) - 1;
            double temp2 = 1 - determ;
            for (int i = 0; i < coefDetemp.Count(); i++)
            {
                result[i] = ((determ - coefDetemp[i]) / temp2) * temp1;
            }
            result[coefDetemp.Count()] = Convert.ToDouble(GetGetAllFishTable(ComboBox.Text, allval.GetLength(1) - 2, allval.GetLength(0) - (allval.GetLength(1) - 1) - 1));
            return result;
        }

        public double[] GetAllFish(double[,] allval, double determ)
        {
            double[] temp = new double[2];
            var n = allval.GetLength(0);
            var m = allval.GetLength(1) - 1;
            double x = determ / (1 - determ);
            double x1 = (n - m -1) / (double)m;
            temp[0] = x * x1;
            temp[1] = Convert.ToDouble(GetGetAllFishTable(ComboBox.Text, allval.GetLength(1) - 1, allval.GetLength(0) - (allval.GetLength(1) - 1) - 1));
            return temp;
        }

        public double GetExp(double[] valueszav, double[,] valuesNzav, double[] coeff)
        {
            var a = GetError(valueszav, valuesNzav, coeff);
            var v = Math.Sqrt(a / (valueszav.Count() - valuesNzav.GetLength(1) - 1));
            return Math.Sqrt(a / (valueszav.Count() - valuesNzav.GetLength(1) - 1));
        }

        public double GetFixDeterm(double determ, double[,] allValues)
        {
            var a = (allValues.GetLength(0) - 1) / (allValues.GetLength(0) - (allValues.GetLength(1) -1) - 1);
            return 1 - ((1 - determ) * a);
        }

        public double GetDeterm(double[] valueszav, double[,] valuesNzav, double[] coeff)
        {
            double temp = 0;
            var exp = GetError(valueszav, valuesNzav, coeff);
            double agv = Avg(valueszav);
            for (int i = 0; i < valueszav.Count(); i++)
            {
                temp += (valueszav[i] - agv) * (valueszav[i] - agv);
            }
            return 1 - (exp / temp);
        }

        public double GetError(double[] valueszav, double[,] valuesNzav, double[] coeff)
        {
            double y, temp = 0;
            for (int j = 0; j < valuesNzav.GetLength(0); j++)
            {
                y = coeff[0];
                for (int i = 0; i < valuesNzav.GetLength(1); i++)
                {
                    y += valuesNzav[j, i] * coeff[i + 1];
                }
                temp += (valueszav[j] - y) * (valueszav[j] - y);
            }

            return temp;
        }

        public string GetResult(double[] resMatr)
        {
            //Уравнение регрессии
            stringBuilder.Clear();
            for (int i = 0; i < resMatr.Length; i++)
            {
                resMatr[i] = Math.Round(resMatr[i], 3);
            }
            stringBuilder.Append("Уравнение регрессии:");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Y=");
            stringBuilder.Append(resMatr[0].ToString());
            for (int i = 1; i < resMatr.Length; i++)
            {
                if (resMatr[i] >= 0)
                {
                    stringBuilder.Append(" +");
                    stringBuilder.Append(resMatr[i].ToString());
                    stringBuilder.Append("*X");
                    stringBuilder.Append(i.ToString());
                }
                else
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(resMatr[i].ToString());
                    stringBuilder.Append("*X");
                    stringBuilder.Append(i.ToString());
                }

            }

            return stringBuilder.ToString();
        }

        public string GetResultCurrentCoeffFish(double[] curretfish)
        {
            stringBuilder.Clear();
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Частный F-критерий:");
            stringBuilder.Append("\r\n");
            for (int i = 0; i < curretfish.Count()-1; i++)
            {
                stringBuilder.Append("Fx");
                stringBuilder.Append((i+1).ToString());
                stringBuilder.Append("=");
                stringBuilder.Append(curretfish[i]);
                stringBuilder.Append("\r\n");
            }

            stringBuilder.Append("Fтаблич=");
            stringBuilder.Append(curretfish[curretfish.Count() - 1].ToString());
            stringBuilder.Append("\r\n");
            return stringBuilder.ToString();
        }

        public string GetResultPairCoefRegres(double[,] resMatr)
        {
            int i;
            stringBuilder.Clear();
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Парные коэффициенты корреляции:");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Y = Зависимая переменная");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Xi = Независимая переменная № i");
            stringBuilder.Append("\r\n");
            for (int j = 0; j < resMatr.GetLength(0)-1; j++)
            {
                i = j + 1;
                do
                {
                    if (j == 0)
                    {
                        stringBuilder.Append("YX");
                        stringBuilder.Append(i.ToString());
                        stringBuilder.Append("=");
                        stringBuilder.Append(resMatr[j, i]);
                        stringBuilder.Append("\r\n");
                    }
                    else
                    {
                        stringBuilder.Append("X");
                        stringBuilder.Append(j.ToString());
                        stringBuilder.Append("X");
                        stringBuilder.Append(i.ToString());
                        stringBuilder.Append("=");
                        stringBuilder.Append(resMatr[j, i]);
                        stringBuilder.Append("\r\n");
                    }
                    i++;
                } while (i < resMatr.GetLength(0));
            }
            return stringBuilder.ToString();
        }

        public string GetResultNormCoeffDeterm(double determ)
        {
            stringBuilder.Clear();
            stringBuilder.Append("Коэффициент детерминации:");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("R^2 =");
            stringBuilder.Append(determ.ToString());
            return stringBuilder.ToString();
        }

        public string GetResultFixCoeffDeterm(double determ)
        {
            stringBuilder.Clear();
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Cкорректированный коэффициент детерминации:");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("R^2 =");
            stringBuilder.Append(determ.ToString());
            return stringBuilder.ToString();
        }

        public string GetResultAllFisher(double fish, double fishtabl)
        {
            stringBuilder.Clear();
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Критерий F:");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("F=");
            stringBuilder.Append(fish.ToString());
            stringBuilder.Append("\r\n");
            stringBuilder.Append("F(табличное)=");
            stringBuilder.Append(fishtabl.ToString());
            return stringBuilder.ToString();
        }

        public string GetResultExp(double exp)
        {
            stringBuilder.Clear();
            stringBuilder.Append("\r\n");
            stringBuilder.Append("Cтандартная ошибка для оценки Y:");
            stringBuilder.Append("\r\n");
            stringBuilder.Append("S=");
            stringBuilder.Append(exp.ToString());
            return stringBuilder.ToString();
        }

        public double[,] Invers(double[,] a)
        {
            Matrix<double> matrix = DenseMatrix.OfArray(a);
            return matrix.Inverse().ToArray();
        }

        public double[,] TranspMatr(double[,] a)
        {
            double[,] matr = new double[dataGridView1.ColumnCount, dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    matr[i, j] = a[j, i];
                }
            }
            return matr;
        }

        public double[,] Multiply_matrix(double[,] array1, double[,] arrary2)
        {
            if (array1.GetLength(1) != arrary2.GetLength(0))
                throw new ArgumentException("Invalid arrays length");
            int commonLength = array1.GetLength(1);

            double[,] res = new double[array1.GetLength(0), arrary2.GetLength(1)];

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    double nextVal = 0;
                    for (int k = 0; k < commonLength; k++)
                    {
                        nextVal += array1[i, k] * arrary2[k, j];
                    }
                    res[i, j] = nextVal;
                    Console.Write("{0} ", res[i, j]);
                }
                Console.WriteLine();
            }
            return res;
        }

        public double[] Multiply_matrix(double[,] A, double[] B)

        
        {
            double[] res = new double[A.GetLength(0)];
            for (int row = 0; row < A.GetLength(0); row++)
            {
                for (int col = 0; col < A.GetLength(1); col++)
                {
                    res[row] += A[row, col] * B[col];
                }
            }
            return res;
        }

        public double[,] GetPairsCorel(double[,] matr)
        {
            int temp = 0;
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                temp += i;
            }
            double[,] vs = new double[matr.GetLength(1), matr.GetLength(1)];
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int i = 0; i < matr.GetLength(1); i++)
                {
                    if (i == j)
                    {
                        vs[i, j] = 1;
                    }
                    else
                    {
                        vs[i, j] = GetCurrentPairsCorel(matr, j, i);
                    }
                }
            }
            return vs;
        }

        public double Avg(double[] arr)
        {
            return arr.Sum() / arr.Length;
        }

        public double GetCurrentPairsCorel(double[,] matr, int x1, int x2)
        {
            double[] vs = new double[matr.GetLength(0)];
            double[] vs1 = new double[matr.GetLength(0)];
            vs = GetM(matr, x1);
            vs1 = GetM(matr, x2);
            double agvall = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                agvall += vs[i] * vs1[i];
            }
            agvall /= matr.GetLength(0);
            double sx1 = standardDeviation(vs);
            return Math.Round((agvall - Avg(vs) * Avg(vs1)) / (standardDeviation(vs) * standardDeviation(vs1)), 3);
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

        public double[] GetM(double[,] matr, int x)
        {
            double[] vs = new double[matr.GetLength(0)];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                vs[i] = matr[i, x];
            }
            return vs;
        }

        private void MultRegress_Load(object sender, EventArgs e)
        {
            selectComboBox.Enabled = false;
            panel1.Enabled = false;
            button2.Enabled = false;
            ComboBox.SelectedIndex = 0;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            panel1.Enabled = false;
            dataGridView1.Columns.Clear();
            zg3.GraphPane.CurveList.Clear();
            zg3.GraphPane.GraphObjList.Clear();
            zg3.Refresh();
            CreateFile.CreateFile.numberСolumns = 0;
            selectComboBox.Items.Clear();
            button2.Enabled = false;
        }

        Plotting plotting = new Plotting();
        private void button2_Click(object sender, EventArgs e)
        {
            var resultStringcolumn = Convert.ToInt32(string.Join(string.Empty, Regex.Matches(selectComboBox.Text, @"\d+").OfType<Match>().Select(m => m.Value)));
            var notzav = GetM(DateRegression.ValOx, resultStringcolumn-1);

            plotting.CreateMultLinerRegGraph(zg3, DateRegression.ValOY.ToList(), notzav.ToList(), DateRegression.CoefRef[resultStringcolumn], DateRegression.CoefRef[0]);
        }


        StreamReader sr, sr2;
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
                                    inputArray = streamReader.ReadToEnd().Replace("\r","").Split('\n').Select(s => s.Trim()).ToList();
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
                                            outp[i] = cl +  " ";
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
