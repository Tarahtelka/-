using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using ZedGraph;



namespace Ocenka_mer_svyzei
{
    public partial class tbs : Form
    {        
        public int count_rows, count_cols;
        newdata data_frm = new newdata();
        Class1 cl = new Class1();
        public tbs()
        {
            InitializeComponent();
            
        }               
        private void tbs_Load(object sender, EventArgs e)
        {
            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
        }        
        private void openFD_File_Click(object sender, EventArgs e)
        {
            data_frm.open_file(dataGV_data);                      
        }               
  
        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_frm.save_data(dataGV_data);
        }
        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFD.Filter = "Text Files (*.txt; *.csv)|*.txt;*.csv|" + "XML Files (*.xml)|*.xml";
                //if (saveFD.ShowDialog() == DialogResult.OK)
                //    this.save_data(saveFD.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка файла!", "Ошибка");
            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int n1 = 0;
            int n2 = 0;
            double x1 = 0;
            double x2 = 0;
            double x1cr, x2cr, qw, sx, sx1, sx2, x, rez, xx, qw1;
            x = 0;
            sx2 = 0;
            try
            {
                for (int i = 0; i < dataGV_data.RowCount - 1; i++)
                {
                    if (Convert.ToInt32(dataGV_data.Rows[i].Cells[0].Value) == 1)
                    {
                        n1++;
                        x1 += Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                        x += Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);

                    }
                    if (Convert.ToInt32(dataGV_data.Rows[i].Cells[0].Value) == 0)
                    {
                        n2++;
                        x2 += Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                        x += Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                    }
                    n++;
                }
                textBox17.Text = n1.ToString();
                textBox18.Text = n2.ToString();
                textBox19.Text = n.ToString();
                x1cr = x1 / n1;
                textBox13.Text = x1cr.ToString();
                x2cr = x2 / n2;
                textBox14.Text = x2cr.ToString();
                qw1 = (n * (n - 1));
                qw = Math.Sqrt((n1 * n2) / qw1);
                //textBox12.Text = qw1.ToString();
                sx1 = x / n;
                textBox15.Text = sx1.ToString();
                for (int i = 0; i < dataGV_data.RowCount - 1; i++)
                {
                    xx = Convert.ToDouble(dataGV_data.Rows[i].Cells[1].Value);
                    sx2 += (xx - sx1) * (xx - sx1);
                }
                sx = Math.Sqrt(sx2 / (n - 1));
                textBox16.Text = sx.ToString();
                rez = (x1cr - x2cr) * qw / sx;
                textBox21.Text = rez.ToString();
                textBox11.Text = "2,13";
                textBox10.Text = "2,1";
                textBox9.Text = "Слабая корреляция данных";
                результатыToolStripMenuItem.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        private void openFD_File_Click_1(object sender, EventArgs e)
        {
            try
            {
                data_frm.open_file(dataGV_data);
                textBox10.Text = "";
                textBox11.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox21.Text = "";
                textBox9.Text = "";
                button1.Enabled = true;
                button2.Enabled = true;
                данныеToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }          
        private void button2_Click(object sender, EventArgs e)
        {
            cl.CreateGraph(zg1, dataGV_data);
            cl.CreateGraph2(zg2, dataGV_data);
        }
    }
}
