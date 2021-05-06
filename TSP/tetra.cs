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
    public partial class tetra : Form
    {        
        public int count_rows, count_cols;        
        public tetra()
        {
            InitializeComponent();
        }

        private void tbs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.Таблица1' table. You can move, or remove it, as needed.
            this.таблица1TableAdapter.Fill(this.db1DataSet.Таблица1);
        }
        newdata data_frm= new newdata(); 
        private void openFD_File_Click(object sender, EventArgs e)
        {
            data_frm.open_file(dataGV_data);
            данныеToolStripMenuItem.Enabled = true;
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
     
        private void openFD_File_Click_1(object sender, EventArgs e)
        {
            data_frm.open_file(dataGV_data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox11.Text = "2,13";
            //textBox10.Text = "2,1";
            //textBox4.Text = "2,55";
            //textBox9.Text = "Связь статически значима";
            результатыToolStripMenuItem.Enabled = true;
        }      
    }
}
