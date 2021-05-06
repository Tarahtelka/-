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
    public partial class Savadiolog : Form
    {
        public Savadiolog()
        {
            InitializeComponent();
        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Savadiolog save_frm = new Savadiolog();
            try
            {
                saveFD.Filter = "Text Files (*.txt; *.csv)|*.txt;*.csv|" + "XML Files (*.xml)|*.xml";
                //if (saveFD.ShowDialog() == DialogResult.OK)
                //    save_frm.save_data(saveFD.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка файла!", "Ошибка");
            }
        }
        string file_name = "";
        //public void save_data(string file_name)
        //{
        //    try
        //    {
        //        if (file_name.Substring((file_name.Length - 3), 3).CompareTo("xml") == 0)
        //        {
        //            // сохранение в xml
        //            try
        //            {
        //                this.file_name = file_name;
        //                DataSet ds = new DataSet();
        //                DataTable Table1 = new DataTable();
        //                ds.Tables.Add(Table1);
        //                for (int i = 0; i <  dataGV_data.Columns.Count; i++)
        //                    ds.Tables[0].Columns.Add(dataGV_data.Columns[i].HeaderText);
        //                string[] output = new string[dataGV_data.Columns.Count];
        //                for (int i = 0; i < dataGV_data.Rows.Count; i++)
        //                {
        //                    for (int j = 0; j < dataGV_data.Columns.Count; j++)
        //                        output[j] = dataGV_data.Rows[i].Cells[j].Value.ToString() + " ";
        //                    ds.Tables[0].Rows.Add(output);
        //                }
        //                ds.Tables[0].Rows[0][0].ToString();
        //                ds.WriteXml(file_name);
        //                ds.WriteXmlSchema(file_name.Substring(0, (file_name.Length - 4)) + ".xsd");
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }
        //        else
        //        {
        //            //сохранение данных в файл *.csv или *.txt
        //            try
        //            {
        //                string output = "";
        //                sw = new StreamWriter(file_name, false, Encoding.Default);
        //                for (int j = 0; j < count_cols; j++) output = output + dataGV_data.Columns[j].HeaderText + " ";
        //                sw.WriteLine(output);
        //                output = "";
        //                for (int i = 0; i < dataGV_data.Rows.Count; i++)
        //                {
        //                    for (int j = 0; j < count_cols; j++)
        //                        output = output + dataGV_data.Rows[i].Cells[j].Value.ToString() + " ";
        //                    sw.WriteLine(output);
        //                    output = "";
        //                }
        //                sw.Close();

        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Ошибка файла!!!", "Ошибка");
        //            }
        //        }
        //        count_rows = dataGV_data.Rows.Count + 1;
        //        count_cols = dataGV_data.Columns.Count;
        //        this.Text = "Данные: " + file_name + ": " + (count_rows - 1) + " x " + count_cols;
        //        MessageBox.Show("Файл сохранен!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ошибка файла!!!", "Ошибка");
        //    }
        //} 
    }
}
