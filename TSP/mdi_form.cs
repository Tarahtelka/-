/* главная форма программы;
 * возможно открытие файла даных;
 * сохранение файла данных;
 * создание нового файла данных;
 * проведение дисперсионного анализа;
 * проведение анализа ТСП;
 * проведенеие анализа соответствий;
 * вызов справки;
 * вызов окна "о программе..."
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
    public partial class mdi_form : Form
    {            
        public mdi_form()
        {
            InitializeComponent();   
        }

        SelectCreatFile data_frm;
        
        private void Help_MenuItem_Click(object sender, EventArgs e)
        {
            // форма со справкой
            help_form help_frm = new help_form();
            help_frm.MdiParent = this;
            help_frm.Show();
        }

        private void About_MenuItem_Click(object sender, EventArgs e)
        {
            // форма "о программе..."
            about_form about_frm = new about_form();
            about_frm.MdiParent = this;
            about_frm.Show();
        }

        private void New_MenuItem_Click(object sender, EventArgs e)
        {
            // создание файла данных
            try
            {
                data_frm = new SelectCreatFile();
                data_frm.MdiParent = this;     
                data_frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_MenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSP_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                diagram1 data_frm = new diagram1();                    
                data_frm.MdiParent = this;
                data_frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void опредеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analysis analysis_frm = new Analysis();
            analysis_frm.MdiParent = this;
            analysis_frm.Show();
        }

        private void произведениеМоментовПирсонаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PearsonFrm pearsFrm = new PearsonFrm();
            pearsFrm.MdiParent = this;
            pearsFrm.Show();
        }

        private void ранговаяКорреляцияСпирменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpearmanFrm spearmFrm = new SpearmanFrm();
            spearmFrm.MdiParent = this;
            spearmFrm.Show();
        }

        private void точечнобисеральныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbs tbs_frm = new tbs();
            tbs_frm.MdiParent = this;
            tbs_frm.Show();
        }

        private void бисеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bs bs_frm = new bs();
            bs_frm.MdiParent = this;
            bs_frm.Show();
        }

        private void ранговобисериальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rbs rbs_frm = new rbs();
            rbs_frm.MdiParent = this;
            rbs_frm.Show();
        }

        private void тетрахорическийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tetra tetra_frm = new tetra();
            tetra_frm.MdiParent = this;
            tetra_frm.Show();
        }

        private void определитьПрименимыйМетодToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnalysisRegression analysisregression_frm = new AnalysisRegression();
            analysisregression_frm.MdiParent = this;
            analysisregression_frm.Show();
        }

        private void простаяЛинейнаяРегрессияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleLinearReg simpleLinearRegression = new SimpleLinearReg();
            simpleLinearRegression.MdiParent = this;
            simpleLinearRegression.Show();
        }

        private void множественнаяЛинейнаяРегрессияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultRegress multRegress = new MultRegress();
            multRegress.MdiParent = this;
            multRegress.Show();
        }

        private void посмотретьИсториюПредварительногоАнализаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectRegression selectRegression = new SelectRegression();
            selectRegression.MdiParent = this;
            selectRegression.Show();
        }

        private void логистическаяРегрессияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogisticRegress multRegress = new LogisticRegress();
            multRegress.MdiParent = this;
            multRegress.Show();
        }
    }
}