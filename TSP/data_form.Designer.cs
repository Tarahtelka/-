namespace Ocenka_mer_svyzei
{
    partial class data_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_form));
            this.dataGV_data = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переименоватьСтолбецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.строкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_create = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_data
            // 
            this.dataGV_data.AllowUserToAddRows = false;
            this.dataGV_data.AllowUserToDeleteRows = false;
            this.dataGV_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_data.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGV_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_data.Location = new System.Drawing.Point(0, 0);
            this.dataGV_data.Name = "dataGV_data";
            this.dataGV_data.RowHeadersVisible = false;
            this.dataGV_data.RowHeadersWidth = 80;
            this.dataGV_data.Size = new System.Drawing.Size(556, 359);
            this.dataGV_data.TabIndex = 0;
            this.dataGV_data.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переименоватьСтолбецToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 70);
            // 
            // переименоватьСтолбецToolStripMenuItem
            // 
            this.переименоватьСтолбецToolStripMenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.rename;
            this.переименоватьСтолбецToolStripMenuItem.Name = "переименоватьСтолбецToolStripMenuItem";
            this.переименоватьСтолбецToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.переименоватьСтолбецToolStripMenuItem.Text = "Переименовать столбец";
            this.переименоватьСтолбецToolStripMenuItem.Click += new System.EventHandler(this.переименоватьСтолбецToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецToolStripMenuItem,
            this.строкуToolStripMenuItem});
            this.добавитьToolStripMenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.plus;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // столбецToolStripMenuItem
            // 
            this.столбецToolStripMenuItem.Name = "столбецToolStripMenuItem";
            this.столбецToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.столбецToolStripMenuItem.Text = "Столбец";
            this.столбецToolStripMenuItem.Click += new System.EventHandler(this.столбецToolStripMenuItem_Click);
            // 
            // строкуToolStripMenuItem
            // 
            this.строкуToolStripMenuItem.Name = "строкуToolStripMenuItem";
            this.строкуToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.строкуToolStripMenuItem.Text = "Строку";
            this.строкуToolStripMenuItem.Click += new System.EventHandler(this.строкуToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецToolStripMenuItem1,
            this.строкуToolStripMenuItem1});
            this.удалитьToolStripMenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.minus;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // столбецToolStripMenuItem1
            // 
            this.столбецToolStripMenuItem1.Name = "столбецToolStripMenuItem1";
            this.столбецToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.столбецToolStripMenuItem1.Text = "Столбец";
            this.столбецToolStripMenuItem1.Click += new System.EventHandler(this.столбецToolStripMenuItem1_Click);
            // 
            // строкуToolStripMenuItem1
            // 
            this.строкуToolStripMenuItem1.Name = "строкуToolStripMenuItem1";
            this.строкуToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.строкуToolStripMenuItem1.Text = "Строку";
            this.строкуToolStripMenuItem1.Click += new System.EventHandler(this.строкуToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество строк:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numericUpDown1, "Укажите количество строк! (максимум 600)");
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(155, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numericUpDown2, "Укажите количество столбцов! (максимум 600)");
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество столбцов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание файла с исходными данными";            
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(155, 80);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(96, 32);
            this.button_create.TabIndex = 5;
            this.button_create.Text = "Создать";
            this.toolTip1.SetToolTip(this.button_create, "Создание таблицы \"объект-признак\"");
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // data_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGV_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "data_form";
            this.Text = "Данные";
            this.Load += new System.EventHandler(this.data_form_Load);
            this.Activated += new System.EventHandler(this.data_form_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.data_form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьСтолбецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem строкуToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}