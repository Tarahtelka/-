using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GemBox.Spreadsheet;
using System.Xml;

namespace Ocenka_mer_svyzei
{
    public partial class newdata : Form
    {
        public newdata()
        {
            InitializeComponent();
        }
        StreamReader sr,sr2;
        public int count_rows, count_cols;
        string file_name = "";        

        public void open_file(DataGridView dg1)
        {
            // считывание данных из файла
           DataGridView dg = dg1;
           try
           {
               openFD.Filter = "Text Files (*.txt)|*.txt|" + "XML Files (*.xml)|*.xml|" + "EXCEL Files (*.xls)|*.xls";
               openFD.RestoreDirectory = true;
               if (openFD.ShowDialog() == DialogResult.OK)
               {
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
                               dg.Columns[0].Name = "X";
                               dg.Columns[0].HeaderText = "X"; // вывод имен столбцов
                               dg.Columns[1].Name = "Y";
                               dg.Columns[1].HeaderText = "Y"; // вывод имен столбцов
                               while ((input = sr.ReadLine()) != null) // считывание информации из файла по-строчно
                               {
                                   i++;
                               }
                               count_rows = i+1;
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
                                   dg.Rows.Add(count_rows-i);                                   
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
                               string[] outp = new string[2];
                               //ds.Tables[0].Columns.Add("X");
                               //ds.Tables[0].Columns.Add("Y");
                               //dg.Columns.Clear();
                               int j = 0;
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
        public void save_data(DataGridView dg1)
        {
            DataGridView dg = dg1;
            try
            {
                saveFD.Filter = "Text Files (*.txt)|*.txt|" + "XML Files (*.xml)|*.xml|" + "EXCEL Files (*.xls)|*.xls";
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
                        else
                        {
                            MessageBox.Show("Неизвестный формат файла!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            double[] xVal = AnalysisClass.generateValues (xScaleCmbBx.Text,
                xDistrCmbBx.Text, Convert.ToInt32(numericUpDown1.Value));
            double[] yVal = AnalysisClass.generateValues(yScaleCmbBx.Text,
                yDistrCmbBx.Text, Convert.ToInt32(numericUpDown1.Value));

            dataGV_data.Columns[0].Name = "X";
            dataGV_data.Columns[0].HeaderText = "X"; // вывод имен столбцов
            dataGV_data.Columns[1].Name = "Y";
            dataGV_data.Columns[1].HeaderText = "Y"; // вывод имен столбцов

            dataGV_data.Rows.Clear();
            for (int i=0; i < numericUpDown1.Value; i++)
            {
                dataGV_data.Rows.Add(xVal[i],yVal[i]);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGV_data.Rows.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_data(dataGV_data);
        }

    }
}