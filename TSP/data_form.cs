/* форма работа с исходными данными; 
 * воозможен ввод данных 
 * из файла формата *.txt, *.csv или *.xml, 
 * а также создание 
 * количества строк, а затем ввода самих данных;
 * возможно сохранение данных в файл формата *.txt, *.csv или *.xml.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ocenka_mer_svyzei
{
    public partial class data_form : Form
    {
        StreamReader sr;
        StreamWriter sw;
        public string[,] data;
        public int count_rows, count_cols;
        public bool flag_close = false;
        int column_index = -1, row_index = -1;
        string file_name = "";

        public data_form()
        {
            InitializeComponent();
        }

        public bool proverka()
        {
            bool flag = false;
            try
            {
                for (int i = 0; i < dataGV_data.Rows.Count; i++)
                    for (int j = 0; j < dataGV_data.Columns.Count; j++)
                    {
                        if (dataGV_data.Rows[i].Cells[j].Value == null)
                        {
                            flag = true;
                            throw new Exception("Данные не должны быть пустыми!!!");
                        }
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
            return flag;
        }
        
        public string [,] read_file()
        {
            // считывание данных из таблицы
            data = new string[count_rows, count_cols];
            for (int j = 0; j < count_cols; j++)
                data[0, j] = dataGV_data.Columns[j].HeaderText;
            for (int i = 1; i < count_rows; i++)
            {
                for (int j = 0; j < count_cols; j++)
                    if (dataGV_data.Rows[i - 1].Cells[j].Value != null) data[i, j] = dataGV_data.Rows[i - 1].Cells[j].Value.ToString().Trim();
                    else data[i, j] = "0";
            }
            return data;
        }

        public void create_file()
        {
            // создание новой таблицы
            groupBox1.Visible = true;
            dataGV_data.Visible = false;
        }
        
        public void open_file(string file_name)
        {
            // считывание данных из файла
            try
            {
                groupBox1.Visible = false;
                dataGV_data.Visible = true;
                cleare_datagrid(dataGV_data, true);
                this.file_name = file_name;
                if (file_name.Substring((file_name.Length - 3), 3).CompareTo("xml") == 0)
                {
                    // считывание данных из файла xml
                    try
                    {
                        DataSet ds = new DataSet();
                        ds.Clear();
                        ds.ReadXml(file_name);
                        ds.ReadXmlSchema(file_name.Substring(0, (file_name.Length - 4)) + ".xsd");
                        dataGV_data.DataSource = ds.Tables[0];
                        count_rows = dataGV_data.Rows.Count + 1;
                        count_cols = dataGV_data.Columns.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка файла!", "Ошибка");
                    }
                }
                else
                {
                    //считывание данных из файла *.csv или *.txt
                    try
                    {
                        string[] row; // одна строка данных
                        // подклюдение файла данных и считывание информации из него
                        sr = new StreamReader(file_name, Encoding.Default);
                        string input;
                        int i = 0;
                        input = sr.ReadLine(); // строка с названиями столбцов
                        row = input.Trim().Split(' ', ';'); // разделение строки на отдельные части
                        count_cols = row.Length;
                        dataGV_data.ColumnCount = count_cols;
                        for (int j = 0; j < count_cols; j++)
                        {
                            dataGV_data.Columns[j].Name = "Column" + (j + 1);
                            dataGV_data.Columns[j].HeaderText = row[j]; // вывод имен столбцов
                            dataGV_data.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        while ((input = sr.ReadLine()) != null) // считывание информации из файла по-строчно
                        {
                            row = input.Trim().Split(' ', ';'); // разделение строки на отдельные части
                            dataGV_data.Rows.Add(row);
                            i++;
                        }
                        sr.Close(); //закрытие файла после считывания у него информации
                        count_rows = i + 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка файла!!!", "Ошибка");
                    }
                }
                this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка файла!!!", "Ошибка");
            }
        }

        public void save_data(string file_name)
        {
            try
            {
                if (file_name.Substring((file_name.Length - 3), 3).CompareTo("xml") == 0)
                {
                    // сохранение в xml
                    try
                    {
                        this.file_name = file_name;
                        DataSet ds = new DataSet();
                        DataTable Table1 = new DataTable();
                        ds.Tables.Add(Table1);
                        for (int i = 0; i < dataGV_data.Columns.Count; i++)
                            ds.Tables[0].Columns.Add(dataGV_data.Columns[i].HeaderText);
                        string[] output = new string[dataGV_data.Columns.Count];
                        for (int i = 0; i < dataGV_data.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGV_data.Columns.Count; j++)
                                output[j] = dataGV_data.Rows[i].Cells[j].Value.ToString() + " ";
                            ds.Tables[0].Rows.Add(output);
                        }
                        ds.Tables[0].Rows[0][0].ToString();
                        ds.WriteXml(file_name);
                        ds.WriteXmlSchema(file_name.Substring(0, (file_name.Length - 4)) + ".xsd");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    //сохранение данных в файл *.csv или *.txt
                    try
                    {
                        string output = "";
                        sw = new StreamWriter(file_name, false, Encoding.Default);
                        for (int j = 0; j < count_cols; j++) output = output + dataGV_data.Columns[j].HeaderText + " ";
                        sw.WriteLine(output);
                        output = "";
                        for (int i = 0; i < dataGV_data.Rows.Count; i++)
                        {
                            for (int j = 0; j < count_cols; j++)
                                output = output + dataGV_data.Rows[i].Cells[j].Value.ToString() + " ";
                            sw.WriteLine(output);
                            output = "";
                        }
                        sw.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка файла!!!", "Ошибка");
                    }
                }
                count_rows = dataGV_data.Rows.Count + 1;
                count_cols = dataGV_data.Columns.Count;
                this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
                MessageBox.Show("Файл сохранен!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка файла!!!", "Ошибка");
            }
        }

        public void cleare_datagrid(DataGridView dg, bool flag)
        {
            // очистка datagrid
            dg.Rows.Clear();
            if (flag) dg.Columns.Clear();
        }

        private void data_form_Load(object sender, EventArgs e)
        {
            flag_close = false;
        }

        private void data_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            flag_close = true;
        }

        private void переименоватьСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (column_index >= 0)
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox("Введите новое имя признака!", "Переименование признака", "Признак", this.MdiParent.Width / 2 - 150, this.MdiParent.Height / 2 - 50);
                if (name != "") dataGV_data.Columns[column_index].HeaderCell.Value = name.Trim().Replace(' ', '_');
            }
            column_index = -1;
        }

        private void строкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (row_index >= 0)
            {
                dataGV_data.Rows.RemoveAt(row_index);
                count_rows--;
            }
            row_index = -1;
            this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
        }

        private void столбецToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (column_index >= 0)
            {
                dataGV_data.Columns.RemoveAt(column_index);
                count_cols--;
            }
            column_index = -1;
            this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
        }

        private void столбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (column_index >= 0)
            {
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Columns" + (count_cols + 1);
                dgvc.HeaderText = "Признак" + (count_cols + 1);
                dataGV_data.Columns.Insert(column_index + 1, dgvc);
                dataGV_data.Columns[column_index + 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                count_cols++;
            }
            column_index = -1;
            this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
        }

        private void строкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (row_index >= 0)
            {
                string[] str = new string[count_cols];
                for (int i = 0; i < count_cols; i++) str[i] = "";
                dataGV_data.Rows.Insert(row_index + 1, str);
                count_rows++;
            }
            row_index = -1;
            this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                column_index = e.ColumnIndex;
                row_index = e.RowIndex;
            }
        }

        private void data_form_Activated(object sender, EventArgs e)
        {
            flag_close = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            // создание новой таблицы "объект-признак"
            try
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
                count_rows = Convert.ToInt32(numericUpDown1.Value);
                count_cols = Convert.ToInt32(numericUpDown2.Value);
                if (count_rows <= 600 && count_cols <= 600)
                {
                    dataGV_data.ColumnCount = count_cols;
                    for (int i = 0; i < count_cols; i++)
                    {
                        dataGV_data.Columns[i].Name = "Columns" + (i + 1);
                        dataGV_data.Columns[i].HeaderText = "Признак" + (i + 1);
                        dataGV_data.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    dataGV_data.RowCount = count_rows;
                    
                    groupBox1.Visible = false;
                    dataGV_data.Visible = true;
                    this.Width = 504;
                    this.Height = 359;
                    this.Text = "Данные: " + count_rows + " x " + count_cols;
                    count_rows++;
                }
                else MessageBox.Show("Введено слишком большое значение!", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}