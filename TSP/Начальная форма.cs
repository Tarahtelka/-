using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    public partial class Начальная_форма : Form
    {
        public Начальная_форма()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                tbs tbs_frm = new tbs();
                tbs_frm.MdiParent = this;
                tbs_frm.Show();
            }
            if (flag == 2)
            {
                bs bs_frm = new bs();
                bs_frm.MdiParent = this;
                bs_frm.Show();
            }
            if (flag == 3)
            {
                rbs rbs_frm = new rbs();
                rbs_frm.MdiParent = this;
                rbs_frm.Show();
            }
            if (flag == 4)
            {
                rbs rbs_frm = new rbs();
                rbs_frm.MdiParent = this;
                rbs_frm.Show();
            }
        }
        int flag;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
            button1.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            flag = 4;
            button1.Enabled = true;
        }

    }
}
