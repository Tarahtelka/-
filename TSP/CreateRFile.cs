using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using GemBox.Spreadsheet;
using System.Text.RegularExpressions;
using System.Linq;

namespace CreateFile
{
    public partial class CreateRFile : Form
    {
        public string headText,columnName;
        List<string> listitems = new List<string>();
        public int temp = 0, max = 0;

        public CreateRFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void addcolumn_Click(object sender, EventArgs e)
        {
            if (CreateFile.numberСolumns != 0)
            {
                headText = "Независимая переменная №" + CreateFile.numberСolumns.ToString();
                columnName = "NZav" + CreateFile.numberСolumns.ToString();
                dataGridView1.Columns.Add(columnName, headText);
                comboBox1.Items.Add(headText);
                DELETEcomboBox.Items.Add(headText);
            }
            else
            {
                dataGridView1.Columns.Add("NZav", "Зависимая переменная");
            }
            CreateFile.numberСolumns++;
        }

        private void deletecolumn_Click(object sender, EventArgs e)
        {
            string resultStringcolumn;
            if (!string.IsNullOrWhiteSpace(DELETEcomboBox.Text))
            {
                resultStringcolumn = string.Join(string.Empty, Regex.Matches(DELETEcomboBox.Text, @"\d+").OfType<Match>().Select(m => m.Value));
                dataGridView1.Columns.Remove("NZav" + resultStringcolumn);
                CreateFile.numberСolumns--;
                DELETEcomboBox.Items.Remove("Независимая переменная №" + resultStringcolumn);
                comboBox1.Items.Remove("Независимая переменная №" + resultStringcolumn);
            }
            else
            {
                MessageBox.Show("Выберите независимую переменную которую хотите удалить");
            }
        }

        private void generateDate_Click(object sender, EventArgs e)
        {
            int numberZClo = 1;
            string resultString = string.Join(string.Empty, Regex.Matches(comboBox1.Text, @"\d+").OfType<Match>().Select(m => m.Value));
            int.TryParse(resultString, out numberZClo);
            if (numericUpDown2.Value <= 0 || string.IsNullOrWhiteSpace(NzDistr.Text) || string.IsNullOrWhiteSpace(NzScalH.Text) || string.IsNullOrWhiteSpace(resultString))
            {
                MessageBox.Show("Введите значения во все поля касающиеся независимой переменной");
            }
            else
            {
                double[] nzVal = CreateFile.generateSample(NzScalH.Text,
                    NzDistr.Text, Convert.ToInt32(numericUpDown2.Value));
                dataGridView1.Rows.Add(Convert.ToInt32(numericUpDown2.Value));

                for (int i = 0; i < Convert.ToInt32(numericUpDown2.Value); i++)
                {
                    this.dataGridView1[numberZClo, i].Value = nzVal[i];
                }
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 1; j < dataGridView1.Rows.Count; j++)
                    {

                        var a = dataGridView1[i, j].Value;
                        if (a != null)
                        {
                            temp = j;
                        }
                    }
                    if (temp > max)
                    {
                        max = temp;
                    }
                    temp = 0;
                }
                max++;
                temp = dataGridView1.Rows.Count;
                if (max < dataGridView1.Rows.Count - 1)
                {
                    for (int j = max; j < temp - 1; j++)
                    {
                        dataGridView1.Rows.RemoveAt(max);
                    }

                }
                max = 0;
                temp = 0;
            }
        }

 
        private void create_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                CreateFile.numberСolumns = int.Parse(textBox1.Text);
                if (CreateFile.numberСolumns < 2)
                {
                    MessageBox.Show("Введите число, больше 2");
                }
                else
                {
                    dataGridView1.Columns.Add("Zav", "Зависимая переменная");
                    for (int i = 1; i < CreateFile.numberСolumns; i++)
                    {
                        headText = "Независимая переменная №" + i.ToString();
                        columnName = "NZav" + i.ToString();
                        dataGridView1.Columns.Add(columnName,headText);
                        comboBox1.Items.Add(headText);
                        DELETEcomboBox.Items.Add(headText);
                    }
                    panel1.Enabled = true;
                    panel2.Enabled = false;                  
                }
            }           
            else
            {
                textBox1.Clear();
                MessageBox.Show("Введите число, больше 2");
            }          
           
        }

        string file_name = "";

        private void button2_Click(object sender, EventArgs e)
        {
            open_file(dataGridView1);
        }

        public void save_data(DataGridView dg1)
        {
            DataGridView dg = dg1;
            try
            {
                saveFD.Filter = "Text Files (*.txt)|*.txt|" + "XML Files (*.xml)|*.xml|" + "EXCEL Files (*.xls)|*.xls|" + "CSV Files (*.csv)|*.csv";
                saveFD.RestoreDirectory = true;
                file_name = saveFD.FileName;
                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    Stream myStream = saveFD.OpenFile();
                    if (myStream != null)
                    {
                        if (saveFD.FileName.Substring((saveFD.FileName.Length - 3), 3).CompareTo("txt") == 0)
                        {

                            StreamWriter myWritet = new StreamWriter(myStream);
                            try
                            {
                                for (int i = 0; i < dg.RowCount - 1; i++)
                                {
                                    for (int j = 0; j < dg.ColumnCount; j++)
                                    {
                                        if (dg.Rows[i].Cells[j].Value == null)
                                            myWritet.Write("  ");
                                        else
                                            myWritet.Write(dg.Rows[i].Cells[j].Value.ToString() + " ");
                                    }
                                    myWritet.WriteLine();
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                myWritet.Close();
                                myStream.Close();
                            }

                        }
                        else if (saveFD.FileName.Substring((saveFD.FileName.Length - 3), 3).CompareTo("xml") == 0)
                        {
                            DataSet ds = new DataSet();
                            DataTable Table1 = new DataTable();
                            ds.Tables.Add(Table1);
                            try
                            {
                                for (int i = 0; i < dg.Columns.Count; i++)
                                    ds.Tables[0].Columns.Add(dg.Columns[i].HeaderText);
                                string[] output = new string[dg.Columns.Count];
                                for (int i = 0; i < dg.Rows.Count - 1; i++)
                                {
                                    for (int j = 0; j < dg.Columns.Count; j++)
                                    {
                                        if (dg.Rows[i].Cells[j].Value == null)
                                            output[j] = "0 ";
                                        else
                                            output[j] = dg.Rows[i].Cells[j].Value.ToString() + " ";
                                    }
                                    ds.Tables[0].Rows.Add(output);
                                }
                                ds.Tables[0].Rows[0][0].ToString();
                                myStream.Close();
                                ds.WriteXml(saveFD.FileName);
                                ds.WriteXmlSchema(saveFD.FileName.Substring(0, (saveFD.FileName.Length - 4)) + ".xsd");

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (saveFD.FileName.Substring((saveFD.FileName.Length - 3), 3).CompareTo("xls") == 0)
                        {
                            DataSet ds = new DataSet();
                            DataTable Table1 = new DataTable();
                            ds.Tables.Add(Table1);
                            try
                            {
                                for (int i = 0; i < dg.Columns.Count; i++)
                                    ds.Tables[0].Columns.Add(dg.Columns[i].HeaderText);
                                string[] output = new string[dg.Columns.Count];
                                for (int i = 0; i < dg.Rows.Count - 1; i++)
                                {
                                    for (int j = 0; j < dg.Columns.Count; j++)
                                    {
                                        if (dg.Rows[i].Cells[j].Value == null)
                                            output[j] = "  ";
                                        else
                                            output[j] = dg.Rows[i].Cells[j].Value.ToString() + " ";
                                    }
                                    ds.Tables[0].Rows.Add(output);
                                }
                                ds.Tables[0].Rows[0][0].ToString();
                                ExcelFile ef2 = new ExcelFile();
                                foreach (DataTable dataTable in ds.Tables)
                                {
                                    ExcelWorksheet ws = ef2.Worksheets.Add(dataTable.TableName);
                                    ws.InsertDataTable(dataTable, "A1", true);
                                }
                                myStream.Close();
                                ef2.SaveXls(saveFD.FileName);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (saveFD.FileName.Substring((saveFD.FileName.Length - 3), 3).CompareTo("csv") == 0)
                        {
                            myStream.Close();
                            try
                            {
                                using (StreamWriter sw = new StreamWriter(saveFD.FileName, true, System.Text.Encoding.Default))
                                {
                                    StringBuilder sb = new StringBuilder();

                                    for (int i = 0; i < dg.Columns.Count; i++)
                                        sb.Append(dg.Columns[i].HeaderText + "; ");
                                    sb.Remove(sb.Length - 2, 2);
                                    if (sb.Length > 2)
                                    {
                                        sb.Remove(sb.Length - 2, 2);
                                    }
                                    sb.AppendLine();


                                    string[] output = new string[dg.Columns.Count];
                                    for (int i = 0; i < dg.Rows.Count - 1; i++)
                                    {
                                        for (int j = 0; j < dg.Columns.Count; j++)
                                        {
                                            if (dg.Rows[i].Cells[j].Value == null)
                                                sb.Append("  ");
                                            else
                                            {
                                                sb.Append(dg.Rows[i].Cells[j].Value.ToString());
                                                if (j+1 != dg.Columns.Count)
                                                    sb.Append(";");
                                            }
                                            
                                        }
                                        sb.AppendLine();
                                    }
                                    sw.WriteLine(sb.ToString());
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неизвестный формат файла!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        StreamReader sr, sr2;

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 0 || string.IsNullOrWhiteSpace(ZDistr.Text) || string.IsNullOrWhiteSpace(ZScalH.Text))
            {
                MessageBox.Show("Введите значения во все поля касающиеся независимой переменной");
            }
            else
            {
                double[] zVal = CreateFile.generateSample(ZScalH.Text,
                   ZDistr.Text, Convert.ToInt32(numericUpDown1.Value));

                dataGridView1.Rows.Add(Convert.ToInt32(numericUpDown1.Value));

                for (int i = 0; i < Convert.ToInt32(numericUpDown1.Value); i++)
                {
                    this.dataGridView1[0, i].Value = zVal[i];

                }

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 1; j < dataGridView1.Rows.Count; j++)
                    {

                        var a = dataGridView1[i, j].Value;
                        if (a != null)
                        {
                            temp = j;
                        }
                    }
                    if (temp > max)
                    {
                        max = temp;
                    }
                    temp = 0;
                }
                max++;
                temp = dataGridView1.Rows.Count;
                if (max < dataGridView1.Rows.Count - 1)
                {
                    for (int j = max; j < temp - 1; j++)
                    {
                        dataGridView1.Rows.RemoveAt(max);
                    }

                }
                max = 0;
                temp = 0;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_data(dataGridView1);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            CreateFile.numberСolumns = 0;
            panel1.Enabled = false;
            panel2.Enabled = true;
            DELETEcomboBox.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void openFile(object sender, EventArgs e)
        {
            open_file(dataGridView1);
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count != 0)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                temp = DELETEcomboBox.Items.Count;
                for (int i = 1; i <= temp; i++)
                {
                    DELETEcomboBox.Items.Remove("Независимая переменная №" + i.ToString());
                    comboBox1.Items.Remove("Независимая переменная №" + i.ToString());
                }
                for (int i = 1; i < CreateFile.numberСolumns; i++)
                {
                    headText = "Независимая переменная №" + i.ToString();
                    comboBox1.Items.Add(headText);
                    DELETEcomboBox.Items.Add(headText);
                }
                temp = 0;
            }
            
        }

        private void CreateRFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateFile.numberСolumns = 0;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int count_rows, count_cols;

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
