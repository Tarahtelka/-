namespace CreateFile
{
    partial class CreateRFile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.create = new System.Windows.Forms.Button();
            this.deletecolumn = new System.Windows.Forms.Button();
            this.addcolumn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DELETEcomboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.generateDate = new System.Windows.Forms.Button();
            this.ZDistr = new System.Windows.Forms.ComboBox();
            this.ZScalH = new System.Windows.Forms.ComboBox();
            this.NzDistr = new System.Windows.Forms.ComboBox();
            this.NzScalH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(263, 17);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(103, 23);
            this.create.TabIndex = 1;
            this.create.Text = "Создать таблицу";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // deletecolumn
            // 
            this.deletecolumn.Location = new System.Drawing.Point(330, 10);
            this.deletecolumn.Name = "deletecolumn";
            this.deletecolumn.Size = new System.Drawing.Size(115, 23);
            this.deletecolumn.TabIndex = 2;
            this.deletecolumn.Text = "Удалить столбец";
            this.deletecolumn.UseVisualStyleBackColor = true;
            this.deletecolumn.Click += new System.EventHandler(this.deletecolumn_Click);
            // 
            // addcolumn
            // 
            this.addcolumn.Location = new System.Drawing.Point(3, 10);
            this.addcolumn.Name = "addcolumn";
            this.addcolumn.Size = new System.Drawing.Size(113, 23);
            this.addcolumn.TabIndex = 3;
            this.addcolumn.Text = "Добавить столбец";
            this.addcolumn.UseVisualStyleBackColor = true;
            this.addcolumn.Click += new System.EventHandler(this.addcolumn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DELETEcomboBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.generateDate);
            this.panel1.Controls.Add(this.ZDistr);
            this.panel1.Controls.Add(this.ZScalH);
            this.panel1.Controls.Add(this.NzDistr);
            this.panel1.Controls.Add(this.NzScalH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addcolumn);
            this.panel1.Controls.Add(this.deletecolumn);
            this.panel1.Location = new System.Drawing.Point(349, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 280);
            this.panel1.TabIndex = 5;
            // 
            // DELETEcomboBox
            // 
            this.DELETEcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DELETEcomboBox.FormattingEnabled = true;
            this.DELETEcomboBox.Location = new System.Drawing.Point(145, 12);
            this.DELETEcomboBox.Name = "DELETEcomboBox";
            this.DELETEcomboBox.Size = new System.Drawing.Size(183, 21);
            this.DELETEcomboBox.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(327, 163);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 19;
            this.button3.Text = "Генерировать зависимую";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(3, 160);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(196, 20);
            this.numericUpDown2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Число выборки";
            // 
            // generateDate
            // 
            this.generateDate.Location = new System.Drawing.Point(3, 186);
            this.generateDate.Name = "generateDate";
            this.generateDate.Size = new System.Drawing.Size(123, 48);
            this.generateDate.TabIndex = 15;
            this.generateDate.Text = "Генерировать независимую";
            this.generateDate.UseVisualStyleBackColor = true;
            this.generateDate.Click += new System.EventHandler(this.generateDate_Click);
            // 
            // ZDistr
            // 
            this.ZDistr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZDistr.FormattingEnabled = true;
            this.ZDistr.Items.AddRange(new object[] {
            "нормальное",
            "не нормальное"});
            this.ZDistr.Location = new System.Drawing.Point(327, 136);
            this.ZDistr.Name = "ZDistr";
            this.ZDistr.Size = new System.Drawing.Size(121, 21);
            this.ZDistr.TabIndex = 14;
            // 
            // ZScalH
            // 
            this.ZScalH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZScalH.FormattingEnabled = true;
            this.ZScalH.Items.AddRange(new object[] {
            "дихотомическая",
            "ранговая",
            "количественная"});
            this.ZScalH.Location = new System.Drawing.Point(327, 109);
            this.ZScalH.Name = "ZScalH";
            this.ZScalH.Size = new System.Drawing.Size(121, 21);
            this.ZScalH.TabIndex = 13;
            // 
            // NzDistr
            // 
            this.NzDistr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NzDistr.FormattingEnabled = true;
            this.NzDistr.Items.AddRange(new object[] {
            "нормальное",
            "не нормальное"});
            this.NzDistr.Location = new System.Drawing.Point(3, 133);
            this.NzDistr.Name = "NzDistr";
            this.NzDistr.Size = new System.Drawing.Size(196, 21);
            this.NzDistr.TabIndex = 12;
            // 
            // NzScalH
            // 
            this.NzScalH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NzScalH.FormattingEnabled = true;
            this.NzScalH.Items.AddRange(new object[] {
            "дихотомическая",
            "ранговая",
            "количественная"});
            this.NzScalH.Location = new System.Drawing.Point(3, 106);
            this.NzScalH.Name = "NzScalH";
            this.NzScalH.Size = new System.Drawing.Size(196, 21);
            this.NzScalH.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Распределение данных";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип шкалы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер переменной";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Зависисмая переменная";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Независимая переменная";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.create);
            this.panel2.Location = new System.Drawing.Point(386, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 62);
            this.panel2.TabIndex = 6;
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(814, 24);
            this.main_menu.TabIndex = 24;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.File_MenuItem.Name = "File_MenuItem";
            this.File_MenuItem.ShortcutKeyDisplayString = "";
            this.File_MenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_MenuItem.Tag = "";
            this.File_MenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openFile);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // CreateRFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.main_menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateRFile";
            this.Text = "Создание файла для регрессионного анализа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateRFile_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button deletecolumn;
        private System.Windows.Forms.Button addcolumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ZDistr;
        private System.Windows.Forms.ComboBox ZScalH;
        private System.Windows.Forms.ComboBox NzDistr;
        private System.Windows.Forms.ComboBox NzScalH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateDate;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ComboBox DELETEcomboBox;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}