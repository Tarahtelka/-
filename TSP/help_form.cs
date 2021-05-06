using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    public partial class help_form : Form
    {
        public help_form()
        {
            InitializeComponent();
        }

        private void help_form_Load(object sender, EventArgs e)
        {
            richTextBox1.Select(0, (richTextBox1.Lines[0] + richTextBox1.Lines[1]).Length);
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }     
    }
}