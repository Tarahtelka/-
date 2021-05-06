namespace Ocenka_mer_svyzei
{
    partial class SpearmanFrm
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
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_File = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.analysisResult = new System.Windows.Forms.GroupBox();
            this.critValTxtBx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.corrValTxtBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.stddevYTxtBx = new System.Windows.Forms.TextBox();
            this.meanYTxtBx = new System.Windows.Forms.TextBox();
            this.stddevXTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.meanXTxtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isCorrelatedTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ySchaleTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xSchaleTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yUniqCountTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xUniqCountTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.volumeTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zg2 = new ZedGraph.ZedGraphControl();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.zg3 = new ZedGraph.ZedGraphControl();
            this.main_menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).BeginInit();
            this.analysisResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1341, 24);
            this.main_menu.TabIndex = 17;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFD_File,
            this.сохранитьToolStripMenuItem,
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
            this.openFD_File.Size = new System.Drawing.Size(132, 22);
            this.openFD_File.Tag = "";
            this.openFD_File.Text = "Открыть";
            this.openFD_File.Click += new System.EventHandler(this.openFD_File_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 380);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // dataGV_data
            // 
            this.dataGV_data.AllowUserToDeleteRows = false;
            this.dataGV_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGV_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_data.Location = new System.Drawing.Point(3, 16);
            this.dataGV_data.Name = "dataGV_data";
            this.dataGV_data.ReadOnly = true;
            this.dataGV_data.RowHeadersWidth = 80;
            this.dataGV_data.Size = new System.Drawing.Size(349, 361);
            this.dataGV_data.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(405, 46);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(118, 23);
            this.calculateBtn.TabIndex = 26;
            this.calculateBtn.Text = "Рассчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // analysisResult
            // 
            this.analysisResult.Controls.Add(this.critValTxtBx);
            this.analysisResult.Controls.Add(this.label10);
            this.analysisResult.Controls.Add(this.corrValTxtBx);
            this.analysisResult.Controls.Add(this.label9);
            this.analysisResult.Controls.Add(this.label15);
            this.analysisResult.Controls.Add(this.label16);
            this.analysisResult.Controls.Add(this.stddevYTxtBx);
            this.analysisResult.Controls.Add(this.meanYTxtBx);
            this.analysisResult.Controls.Add(this.stddevXTxtBx);
            this.analysisResult.Controls.Add(this.label7);
            this.analysisResult.Controls.Add(this.meanXTxtBx);
            this.analysisResult.Controls.Add(this.label8);
            this.analysisResult.Controls.Add(this.isCorrelatedTxtBx);
            this.analysisResult.Controls.Add(this.label6);
            this.analysisResult.Controls.Add(this.ySchaleTxtBx);
            this.analysisResult.Controls.Add(this.label4);
            this.analysisResult.Controls.Add(this.xSchaleTxtBx);
            this.analysisResult.Controls.Add(this.label5);
            this.analysisResult.Controls.Add(this.yUniqCountTxtBx);
            this.analysisResult.Controls.Add(this.label3);
            this.analysisResult.Controls.Add(this.xUniqCountTxtBx);
            this.analysisResult.Controls.Add(this.label2);
            this.analysisResult.Controls.Add(this.volumeTxtBx);
            this.analysisResult.Controls.Add(this.label1);
            this.analysisResult.Location = new System.Drawing.Point(381, 80);
            this.analysisResult.Name = "analysisResult";
            this.analysisResult.Size = new System.Drawing.Size(516, 332);
            this.analysisResult.TabIndex = 25;
            this.analysisResult.TabStop = false;
            this.analysisResult.Text = "Результаты рассчёта";
            // 
            // critValTxtBx
            // 
            this.critValTxtBx.Location = new System.Drawing.Point(262, 211);
            this.critValTxtBx.Name = "critValTxtBx";
            this.critValTxtBx.Size = new System.Drawing.Size(100, 20);
            this.critValTxtBx.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Критическое значение на уровне значимости 5%";
            // 
            // corrValTxtBx
            // 
            this.corrValTxtBx.Location = new System.Drawing.Point(262, 185);
            this.corrValTxtBx.Name = "corrValTxtBx";
            this.corrValTxtBx.Size = new System.Drawing.Size(100, 20);
            this.corrValTxtBx.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Значение коэффициента корреляции";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Стандартное отклонение";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Среднее";
            // 
            // stddevYTxtBx
            // 
            this.stddevYTxtBx.Location = new System.Drawing.Point(405, 141);
            this.stddevYTxtBx.Name = "stddevYTxtBx";
            this.stddevYTxtBx.Size = new System.Drawing.Size(93, 20);
            this.stddevYTxtBx.TabIndex = 25;
            // 
            // meanYTxtBx
            // 
            this.meanYTxtBx.Location = new System.Drawing.Point(405, 115);
            this.meanYTxtBx.Name = "meanYTxtBx";
            this.meanYTxtBx.Size = new System.Drawing.Size(93, 20);
            this.meanYTxtBx.TabIndex = 23;
            // 
            // stddevXTxtBx
            // 
            this.stddevXTxtBx.Location = new System.Drawing.Point(152, 140);
            this.stddevXTxtBx.Name = "stddevXTxtBx";
            this.stddevXTxtBx.Size = new System.Drawing.Size(98, 20);
            this.stddevXTxtBx.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Стандартное отклонение";
            // 
            // meanXTxtBx
            // 
            this.meanXTxtBx.Location = new System.Drawing.Point(152, 114);
            this.meanXTxtBx.Name = "meanXTxtBx";
            this.meanXTxtBx.Size = new System.Drawing.Size(98, 20);
            this.meanXTxtBx.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Среднее";
            // 
            // isCorrelatedTxtBx
            // 
            this.isCorrelatedTxtBx.Location = new System.Drawing.Point(165, 264);
            this.isCorrelatedTxtBx.Name = "isCorrelatedTxtBx";
            this.isCorrelatedTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.isCorrelatedTxtBx.Size = new System.Drawing.Size(244, 20);
            this.isCorrelatedTxtBx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вывод";
            // 
            // ySchaleTxtBx
            // 
            this.ySchaleTxtBx.Location = new System.Drawing.Point(327, 87);
            this.ySchaleTxtBx.Name = "ySchaleTxtBx";
            this.ySchaleTxtBx.Size = new System.Drawing.Size(171, 20);
            this.ySchaleTxtBx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шкала Y";
            // 
            // xSchaleTxtBx
            // 
            this.xSchaleTxtBx.Location = new System.Drawing.Point(81, 86);
            this.xSchaleTxtBx.Name = "xSchaleTxtBx";
            this.xSchaleTxtBx.Size = new System.Drawing.Size(169, 20);
            this.xSchaleTxtBx.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Шкала X";
            // 
            // yUniqCountTxtBx
            // 
            this.yUniqCountTxtBx.Location = new System.Drawing.Point(398, 61);
            this.yUniqCountTxtBx.Name = "yUniqCountTxtBx";
            this.yUniqCountTxtBx.Size = new System.Drawing.Size(100, 20);
            this.yUniqCountTxtBx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество значений Y";
            // 
            // xUniqCountTxtBx
            // 
            this.xUniqCountTxtBx.Location = new System.Drawing.Point(140, 61);
            this.xUniqCountTxtBx.Name = "xUniqCountTxtBx";
            this.xUniqCountTxtBx.Size = new System.Drawing.Size(110, 20);
            this.xUniqCountTxtBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество значений X";
            // 
            // volumeTxtBx
            // 
            this.volumeTxtBx.Location = new System.Drawing.Point(254, 24);
            this.volumeTxtBx.Name = "volumeTxtBx";
            this.volumeTxtBx.Size = new System.Drawing.Size(100, 20);
            this.volumeTxtBx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объем выборки";
            // 
            // zg2
            // 
            this.zg2.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg2.Location = new System.Drawing.Point(457, 426);
            this.zg2.Name = "zg2";
            this.zg2.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg2.ScrollGrace = 0D;
            this.zg2.ScrollMaxX = 0D;
            this.zg2.ScrollMaxY = 0D;
            this.zg2.ScrollMaxY2 = 0D;
            this.zg2.ScrollMinX = 0D;
            this.zg2.ScrollMinY = 0D;
            this.zg2.ScrollMinY2 = 0D;
            this.zg2.Size = new System.Drawing.Size(439, 297);
            this.zg2.TabIndex = 28;
            // 
            // zg1
            // 
            this.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg1.Location = new System.Drawing.Point(12, 426);
            this.zg1.Name = "zg1";
            this.zg1.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.Size = new System.Drawing.Size(439, 297);
            this.zg1.TabIndex = 27;
            // 
            // zg3
            // 
            this.zg3.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg3.Location = new System.Drawing.Point(902, 426);
            this.zg3.Name = "zg3";
            this.zg3.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg3.ScrollGrace = 0D;
            this.zg3.ScrollMaxX = 0D;
            this.zg3.ScrollMaxY = 0D;
            this.zg3.ScrollMaxY2 = 0D;
            this.zg3.ScrollMinX = 0D;
            this.zg3.ScrollMinY = 0D;
            this.zg3.ScrollMinY2 = 0D;
            this.zg3.Size = new System.Drawing.Size(439, 297);
            this.zg3.TabIndex = 29;
            // 
            // SpearmanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.zg3);
            this.Controls.Add(this.zg2);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.analysisResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.main_menu);
            this.Name = "SpearmanFrm";
            this.Text = "Ранговая корреляция Спирмена";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).EndInit();
            this.analysisResult.ResumeLayout(false);
            this.analysisResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFD_File;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGV_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.GroupBox analysisResult;
        private System.Windows.Forms.TextBox critValTxtBx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox corrValTxtBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox stddevYTxtBx;
        private System.Windows.Forms.TextBox meanYTxtBx;
        private System.Windows.Forms.TextBox stddevXTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox meanXTxtBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox isCorrelatedTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ySchaleTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xSchaleTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yUniqCountTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xUniqCountTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox volumeTxtBx;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zg2;
        private ZedGraph.ZedGraphControl zg1;
        private ZedGraph.ZedGraphControl zg3;
    }
}