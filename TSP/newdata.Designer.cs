namespace Ocenka_mer_svyzei
{
    partial class newdata
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
            this.dataGV_data = new System.Windows.Forms.DataGridView();
            this.переменная_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.переменная_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.generateBtn = new System.Windows.Forms.Button();
            this.xScaleCmbBx = new System.Windows.Forms.ComboBox();
            this.yDistrCmbBx = new System.Windows.Forms.ComboBox();
            this.yScaleCmbBx = new System.Windows.Forms.ComboBox();
            this.xDistrCmbBx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_data
            // 
            this.dataGV_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.переменная_x,
            this.переменная_Y});
            this.dataGV_data.Location = new System.Drawing.Point(13, 39);
            this.dataGV_data.Name = "dataGV_data";
            this.dataGV_data.Size = new System.Drawing.Size(246, 453);
            this.dataGV_data.TabIndex = 5;
            // 
            // переменная_x
            // 
            this.переменная_x.HeaderText = "X";
            this.переменная_x.Name = "переменная_x";
            // 
            // переменная_Y
            // 
            this.переменная_Y.HeaderText = "Y";
            this.переменная_Y.Name = "переменная_Y";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(305, 226);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(160, 23);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = "Генерировать данные";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // xScaleCmbBx
            // 
            this.xScaleCmbBx.AutoCompleteCustomSource.AddRange(new string[] {
            "дихотомическая",
            "ранговая",
            "количественная"});
            this.xScaleCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xScaleCmbBx.FormattingEnabled = true;
            this.xScaleCmbBx.Items.AddRange(new object[] {
            "дихотомическая",
            "ранговая",
            "количественная"});
            this.xScaleCmbBx.Location = new System.Drawing.Point(368, 53);
            this.xScaleCmbBx.Name = "xScaleCmbBx";
            this.xScaleCmbBx.Size = new System.Drawing.Size(121, 21);
            this.xScaleCmbBx.TabIndex = 8;
            // 
            // yDistrCmbBx
            // 
            this.yDistrCmbBx.AutoCompleteCustomSource.AddRange(new string[] {
            "нормальное",
            "не нормальное"});
            this.yDistrCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yDistrCmbBx.FormattingEnabled = true;
            this.yDistrCmbBx.Items.AddRange(new object[] {
            "нормальное",
            "не нормальное"});
            this.yDistrCmbBx.Location = new System.Drawing.Point(368, 158);
            this.yDistrCmbBx.Name = "yDistrCmbBx";
            this.yDistrCmbBx.Size = new System.Drawing.Size(121, 21);
            this.yDistrCmbBx.TabIndex = 9;
            // 
            // yScaleCmbBx
            // 
            this.yScaleCmbBx.AutoCompleteCustomSource.AddRange(new string[] {
            "дихотомическая",
            "ранговая",
            "количественная"});
            this.yScaleCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yScaleCmbBx.FormattingEnabled = true;
            this.yScaleCmbBx.Items.AddRange(new object[] {
            "дихотомическая",
            "ранговая",
            "количественная"});
            this.yScaleCmbBx.Location = new System.Drawing.Point(368, 132);
            this.yScaleCmbBx.Name = "yScaleCmbBx";
            this.yScaleCmbBx.Size = new System.Drawing.Size(121, 21);
            this.yScaleCmbBx.TabIndex = 10;
            // 
            // xDistrCmbBx
            // 
            this.xDistrCmbBx.AutoCompleteCustomSource.AddRange(new string[] {
            "нормальное",
            "не нормальное"});
            this.xDistrCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xDistrCmbBx.FormattingEnabled = true;
            this.xDistrCmbBx.Items.AddRange(new object[] {
            "нормальное",
            "не нормальное"});
            this.xDistrCmbBx.Location = new System.Drawing.Point(368, 79);
            this.xDistrCmbBx.Name = "xDistrCmbBx";
            this.xDistrCmbBx.Size = new System.Drawing.Size(121, 21);
            this.xDistrCmbBx.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Шкала X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Шкала Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Распределение X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Распределение Y";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(368, 191);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Объем выборки";
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(607, 24);
            this.main_menu.TabIndex = 23;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
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
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // newdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 508);
            this.Controls.Add(this.main_menu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xDistrCmbBx);
            this.Controls.Add(this.yScaleCmbBx);
            this.Controls.Add(this.yDistrCmbBx);
            this.Controls.Add(this.xScaleCmbBx);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.dataGV_data);
            this.Name = "newdata";
            this.Text = "Создание файла данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_data;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn переменная_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn переменная_Y;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.ComboBox xScaleCmbBx;
        private System.Windows.Forms.ComboBox yDistrCmbBx;
        private System.Windows.Forms.ComboBox yScaleCmbBx;
        private System.Windows.Forms.ComboBox xDistrCmbBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}