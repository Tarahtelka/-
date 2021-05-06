namespace Ocenka_mer_svyzei
{
    partial class bs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db2DataSet = new Ocenka_mer_svyzei.db2DataSet();
            this.таблица1TableAdapter = new Ocenka_mer_svyzei.db2DataSetTableAdapters.Таблица1TableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_File = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.zg2 = new ZedGraph.ZedGraphControl();
            this.button2 = new System.Windows.Forms.Button();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_data);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 472);
            this.groupBox1.TabIndex = 7;
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
            this.dataGV_data.Size = new System.Drawing.Size(393, 453);
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
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.db2DataSet;
            // 
            // db2DataSet
            // 
            this.db2DataSet.DataSetName = "db2DataSet";
            this.db2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 518);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 472);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сводка результатов оценивания";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(288, 342);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 36;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(288, 276);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 34;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(288, 239);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 33;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(288, 199);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 32;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(288, 130);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 30;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(288, 96);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 29;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(288, 65);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 28;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(288, 299);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Критическое значение на уровне значимости 5%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ВЫВОД";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(47, 419);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(377, 20);
            this.textBox9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Бисериальный коэффициент корреляции";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(288, 366);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(10, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Oценка значимости связи";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Объем выборки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Число объектов с 0 по Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Число объектов с 1 по Y";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(288, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ордината  в точке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Общее среднее по всем X объектам";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Среднее по X объектов со значением 0 по Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Среднее по X объектов со значением 1 по Y";
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1057, 24);
            this.main_menu.TabIndex = 11;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFD_File,
            this.сохранитьToolStripMenuItem});
            this.File_MenuItem.Name = "File_MenuItem";
            this.File_MenuItem.ShortcutKeyDisplayString = "";
            this.File_MenuItem.Size = new System.Drawing.Size(45, 20);
            this.File_MenuItem.Tag = "";
            this.File_MenuItem.Text = "Файл";
            // 
            // openFD_File
            // 
            this.openFD_File.Name = "openFD_File";
            this.openFD_File.ShortcutKeyDisplayString = "";
            this.openFD_File.Size = new System.Drawing.Size(152, 22);
            this.openFD_File.Tag = "";
            this.openFD_File.Text = "Открыть";
            this.openFD_File.Click += new System.EventHandler(this.openFD_File_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.результатыToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.Enabled = false;
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.данныеToolStripMenuItem.Text = "Данные";
            this.данныеToolStripMenuItem.Click += new System.EventHandler(this.данныеToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Enabled = false;
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.результатыToolStripMenuItem_Click);
            // 
            // zg2
            // 
            this.zg2.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg2.Location = new System.Drawing.Point(618, 350);
            this.zg2.Name = "zg2";
            this.zg2.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg2.ScrollGrace = 0;
            this.zg2.ScrollMaxX = 0;
            this.zg2.ScrollMaxY = 0;
            this.zg2.ScrollMaxY2 = 0;
            this.zg2.ScrollMinX = 0;
            this.zg2.ScrollMinY = 0;
            this.zg2.ScrollMinY2 = 0;
            this.zg2.Size = new System.Drawing.Size(439, 297);
            this.zg2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(421, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Проверить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zg1
            // 
            this.zg1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zg1.Location = new System.Drawing.Point(618, 47);
            this.zg1.Name = "zg1";
            this.zg1.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zg1.ScrollGrace = 0;
            this.zg1.ScrollMaxX = 0;
            this.zg1.ScrollMaxY = 0;
            this.zg1.ScrollMaxY2 = 0;
            this.zg1.ScrollMinX = 0;
            this.zg1.ScrollMinY = 0;
            this.zg1.ScrollMinY2 = 0;
            this.zg1.Size = new System.Drawing.Size(439, 297);
            this.zg1.TabIndex = 16;
            // 
            // bs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.zg2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.zg1);
            this.Controls.Add(this.main_menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bs";
            this.Text = "Бисериальный коэффициент корреляции";
            this.Load += new System.EventHandler(this.bs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGV_data;
        private db2DataSet db2DataSet;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private Ocenka_mer_svyzei.db2DataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFD_File;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox21;
        private ZedGraph.ZedGraphControl zg2;
        private System.Windows.Forms.Button button2;
        private ZedGraph.ZedGraphControl zg1;


    }
}