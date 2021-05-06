namespace Ocenka_mer_svyzei
{
    partial class SimpleLinearReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_File = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExplCorr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StandrExp = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Oy = new System.Windows.Forms.TextBox();
            this.koeffReg = new System.Windows.Forms.TextBox();
            this.PirsCorr = new System.Windows.Forms.TextBox();
            this.StandrtDevNZav = new System.Windows.Forms.TextBox();
            this.StandartDevZav = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.zg2 = new ZedGraph.ZedGraphControl();
            this.main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(800, 24);
            this.main_menu.TabIndex = 17;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFD_File,
            this.очиститьToolStripMenuItem});
            this.File_MenuItem.Name = "File_MenuItem";
            this.File_MenuItem.ShortcutKeyDisplayString = "";
            this.File_MenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_MenuItem.Tag = "";
            this.File_MenuItem.Text = "Файл";
            // 
            // openFD_File
            // 
            this.openFD_File.Name = "openFD_File";
            this.openFD_File.ShortcutKeyDisplayString = "";
            this.openFD_File.Size = new System.Drawing.Size(126, 22);
            this.openFD_File.Tag = "";
            this.openFD_File.Text = "Открыть";
            this.openFD_File.Click += new System.EventHandler(this.openFD_File_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(286, 411);
            this.dataGridView1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExplCorr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StandrExp);
            this.panel1.Controls.Add(this.v);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Oy);
            this.panel1.Controls.Add(this.koeffReg);
            this.panel1.Controls.Add(this.PirsCorr);
            this.panel1.Controls.Add(this.StandrtDevNZav);
            this.panel1.Controls.Add(this.StandartDevZav);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(324, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 225);
            this.panel1.TabIndex = 19;
            // 
            // ExplCorr
            // 
            this.ExplCorr.Location = new System.Drawing.Point(400, 103);
            this.ExplCorr.Name = "ExplCorr";
            this.ExplCorr.Size = new System.Drawing.Size(24, 20);
            this.ExplCorr.TabIndex = 14;
            this.ExplCorr.Text = "?";
            this.ExplCorr.UseVisualStyleBackColor = true;
            this.ExplCorr.Click += new System.EventHandler(this.ExplCorr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Стандартная ошибка";
            // 
            // StandrExp
            // 
            this.StandrExp.Location = new System.Drawing.Point(294, 181);
            this.StandrExp.Name = "StandrExp";
            this.StandrExp.ReadOnly = true;
            this.StandrExp.Size = new System.Drawing.Size(100, 20);
            this.StandrExp.TabIndex = 11;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(18, 158);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(122, 13);
            this.v.TabIndex = 10;
            this.v.Text = "Нулевой коэффициент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Коэффициент линейной регрессии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Коэффициент корреляции Пирсона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стандартное отклонение независимой переменной";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стандартное отклонение зависимой переменной";
            // 
            // Oy
            // 
            this.Oy.Location = new System.Drawing.Point(294, 155);
            this.Oy.Name = "Oy";
            this.Oy.ReadOnly = true;
            this.Oy.Size = new System.Drawing.Size(100, 20);
            this.Oy.TabIndex = 5;
            // 
            // koeffReg
            // 
            this.koeffReg.Location = new System.Drawing.Point(294, 129);
            this.koeffReg.Name = "koeffReg";
            this.koeffReg.ReadOnly = true;
            this.koeffReg.Size = new System.Drawing.Size(100, 20);
            this.koeffReg.TabIndex = 4;
            // 
            // PirsCorr
            // 
            this.PirsCorr.Location = new System.Drawing.Point(294, 103);
            this.PirsCorr.Name = "PirsCorr";
            this.PirsCorr.ReadOnly = true;
            this.PirsCorr.Size = new System.Drawing.Size(100, 20);
            this.PirsCorr.TabIndex = 3;
            // 
            // StandrtDevNZav
            // 
            this.StandrtDevNZav.Location = new System.Drawing.Point(294, 77);
            this.StandrtDevNZav.Name = "StandrtDevNZav";
            this.StandrtDevNZav.ReadOnly = true;
            this.StandrtDevNZav.Size = new System.Drawing.Size(100, 20);
            this.StandrtDevNZav.TabIndex = 2;
            // 
            // StandartDevZav
            // 
            this.StandartDevZav.Location = new System.Drawing.Point(294, 51);
            this.StandartDevZav.Name = "StandartDevZav";
            this.StandartDevZav.ReadOnly = true;
            this.StandartDevZav.Size = new System.Drawing.Size(100, 20);
            this.StandartDevZav.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calcLinerRegress);
            // 
            // zg2
            // 
            this.zg2.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg2.Location = new System.Drawing.Point(324, 257);
            this.zg2.Name = "zg2";
            this.zg2.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg2.ScrollGrace = 0D;
            this.zg2.ScrollMaxX = 0D;
            this.zg2.ScrollMaxY = 0D;
            this.zg2.ScrollMaxY2 = 0D;
            this.zg2.ScrollMinX = 0D;
            this.zg2.ScrollMinY = 0D;
            this.zg2.ScrollMinY2 = 0D;
            this.zg2.Size = new System.Drawing.Size(465, 297);
            this.zg2.TabIndex = 21;
            // 
            // SimpleLinearReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.zg2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.main_menu);
            this.Name = "SimpleLinearReg";
            this.Text = "Простая линейная регрессия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimpleLinearRegression_FormClosing);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFD_File;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Oy;
        private System.Windows.Forms.TextBox koeffReg;
        private System.Windows.Forms.TextBox PirsCorr;
        private System.Windows.Forms.TextBox StandrtDevNZav;
        private System.Windows.Forms.TextBox StandartDevZav;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StandrExp;
        private System.Windows.Forms.Label label5;
        private ZedGraph.ZedGraphControl zg2;
        private System.Windows.Forms.Button ExplCorr;
    }
}