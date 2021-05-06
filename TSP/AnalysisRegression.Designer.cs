using System;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    partial class AnalysisRegression
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_File = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.variableanalysisbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Numberofvalues = new System.Windows.Forms.TextBox();
            this.numberuniquevalues = new System.Windows.Forms.TextBox();
            this.scaletype = new System.Windows.Forms.TextBox();
            this.TypeDistr = new System.Windows.Forms.TextBox();
            this.avg = new System.Windows.Forms.TextBox();
            this.standarddeviation = new System.Windows.Forms.TextBox();
            this.skewness = new System.Windows.Forms.TextBox();
            this.piko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AnalizMetod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.main_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(891, 24);
            this.main_menu.TabIndex = 16;
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
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // zg1
            // 
            this.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg1.Location = new System.Drawing.Point(12, 394);
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
            this.zg1.TabIndex = 20;
            // 
            // variableanalysisbutton
            // 
            this.variableanalysisbutton.Location = new System.Drawing.Point(235, 17);
            this.variableanalysisbutton.Name = "variableanalysisbutton";
            this.variableanalysisbutton.Size = new System.Drawing.Size(140, 23);
            this.variableanalysisbutton.TabIndex = 0;
            this.variableanalysisbutton.Text = "Анализ переменной";
            this.variableanalysisbutton.UseVisualStyleBackColor = true;
            this.variableanalysisbutton.Click += new System.EventHandler(this.variableanalysisbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Numberofvalues
            // 
            this.Numberofvalues.Location = new System.Drawing.Point(264, 55);
            this.Numberofvalues.Name = "Numberofvalues";
            this.Numberofvalues.ReadOnly = true;
            this.Numberofvalues.Size = new System.Drawing.Size(100, 20);
            this.Numberofvalues.TabIndex = 2;
            // 
            // numberuniquevalues
            // 
            this.numberuniquevalues.Location = new System.Drawing.Point(264, 81);
            this.numberuniquevalues.Name = "numberuniquevalues";
            this.numberuniquevalues.ReadOnly = true;
            this.numberuniquevalues.Size = new System.Drawing.Size(100, 20);
            this.numberuniquevalues.TabIndex = 3;
            // 
            // scaletype
            // 
            this.scaletype.Location = new System.Drawing.Point(264, 107);
            this.scaletype.Name = "scaletype";
            this.scaletype.ReadOnly = true;
            this.scaletype.Size = new System.Drawing.Size(100, 20);
            this.scaletype.TabIndex = 4;
            // 
            // TypeDistr
            // 
            this.TypeDistr.Location = new System.Drawing.Point(264, 133);
            this.TypeDistr.Name = "TypeDistr";
            this.TypeDistr.ReadOnly = true;
            this.TypeDistr.Size = new System.Drawing.Size(100, 20);
            this.TypeDistr.TabIndex = 5;
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(264, 159);
            this.avg.Name = "avg";
            this.avg.ReadOnly = true;
            this.avg.Size = new System.Drawing.Size(100, 20);
            this.avg.TabIndex = 6;
            // 
            // standarddeviation
            // 
            this.standarddeviation.Location = new System.Drawing.Point(264, 185);
            this.standarddeviation.Name = "standarddeviation";
            this.standarddeviation.ReadOnly = true;
            this.standarddeviation.Size = new System.Drawing.Size(100, 20);
            this.standarddeviation.TabIndex = 7;
            // 
            // skewness
            // 
            this.skewness.Location = new System.Drawing.Point(264, 211);
            this.skewness.Name = "skewness";
            this.skewness.ReadOnly = true;
            this.skewness.Size = new System.Drawing.Size(100, 20);
            this.skewness.TabIndex = 8;
            // 
            // piko
            // 
            this.piko.Location = new System.Drawing.Point(264, 237);
            this.piko.Name = "piko";
            this.piko.ReadOnly = true;
            this.piko.Size = new System.Drawing.Size(100, 20);
            this.piko.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество значений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количесвто уникальных значений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип шкалы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Тип распределения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Среднее значение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Стандартное отклонение";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Скошенность";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Пикообразность";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 271);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(197, 50);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // AnalizMetod
            // 
            this.AnalizMetod.Location = new System.Drawing.Point(224, 271);
            this.AnalizMetod.Name = "AnalizMetod";
            this.AnalizMetod.Size = new System.Drawing.Size(140, 50);
            this.AnalizMetod.TabIndex = 35;
            this.AnalizMetod.Text = "Предложить метод исследования";
            this.AnalizMetod.UseVisualStyleBackColor = true;
            this.AnalizMetod.Click += new System.EventHandler(this.AnalizMetod_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 40);
            this.button2.TabIndex = 36;
            this.button2.Text = "Показать полный отчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AnalizMetod);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.piko);
            this.panel1.Controls.Add(this.skewness);
            this.panel1.Controls.Add(this.standarddeviation);
            this.panel1.Controls.Add(this.avg);
            this.panel1.Controls.Add(this.TypeDistr);
            this.panel1.Controls.Add(this.scaletype);
            this.panel1.Controls.Add(this.numberuniquevalues);
            this.panel1.Controls.Add(this.Numberofvalues);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.variableanalysisbutton);
            this.panel1.Location = new System.Drawing.Point(463, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 386);
            this.panel1.TabIndex = 17;
            // 
            // AnalysisRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 703);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_menu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnalysisRegression";
            this.Text = "Определение методов регрессии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalysisRegression_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AnalysisRegression_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFD;
        private ZedGraph.ZedGraphControl zg1;
        private ToolStripMenuItem openFD_File;
        private Button variableanalysisbutton;
        private ComboBox comboBox1;
        private TextBox Numberofvalues;
        private TextBox numberuniquevalues;
        private TextBox scaletype;
        private TextBox TypeDistr;
        private TextBox avg;
        private TextBox standarddeviation;
        private TextBox skewness;
        private TextBox piko;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label14;
        private Label label13;
        private RichTextBox richTextBox1;
        private Button AnalizMetod;
        private Button button2;
        private Panel panel1;
    }
}