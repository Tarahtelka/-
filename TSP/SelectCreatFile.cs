using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateFile;

namespace Ocenka_mer_svyzei
{
    public partial class SelectCreatFile : Form
    {
        public SelectCreatFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newdata data_frm;
            CreateRFile createRFile;
            if (radioButton2.Checked)
            {

                data_frm = new newdata();
                data_frm.Show();
                this.Close();
            }
            else if (radioButton1.Checked)
            {
                createRFile = new CreateRFile();
                createRFile.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите метод исследования");
            }

        }
    }
}
