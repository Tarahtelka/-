namespace Ocenka_mer_svyzei
{
    partial class mdi_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_form));
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регрессионоеИсследованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.определитьПрименимыйМетодToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.простаяЛинейнаяРегрессияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.множественнаяЛинейнаяРегрессияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опредеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.произведениеМоментовПирсонаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ранговаяКорреляцияСпирменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечнобисеральныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бисеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ранговобисериальныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тетрахорическийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_About_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem,
            this.select_MenuItem,
            this.Help_About_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1012, 24);
            this.main_menu.TabIndex = 9;
            this.main_menu.Text = "menuStrip1";
            // 
            // File_MenuItem
            // 
            this.File_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_MenuItem,
            this.toolStripSeparator1,
            this.Exit_MenuItem});
            this.File_MenuItem.Name = "File_MenuItem";
            this.File_MenuItem.ShortcutKeyDisplayString = "";
            this.File_MenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_MenuItem.Tag = "";
            this.File_MenuItem.Text = "Файл";
            // 
            // New_MenuItem
            // 
            this.New_MenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.UtilityText;
            this.New_MenuItem.Name = "New_MenuItem";
            this.New_MenuItem.ShortcutKeyDisplayString = "";
            this.New_MenuItem.Size = new System.Drawing.Size(117, 22);
            this.New_MenuItem.Tag = "";
            this.New_MenuItem.Text = "Создать";
            this.New_MenuItem.Click += new System.EventHandler(this.New_MenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // Exit_MenuItem
            // 
            this.Exit_MenuItem.Name = "Exit_MenuItem";
            this.Exit_MenuItem.Size = new System.Drawing.Size(117, 22);
            this.Exit_MenuItem.Text = "Выход";
            this.Exit_MenuItem.Click += new System.EventHandler(this.Exit_MenuItem_Click);
            // 
            // select_MenuItem
            // 
            this.select_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регрессионоеИсследованиеToolStripMenuItem,
            this.корреToolStripMenuItem});
            this.select_MenuItem.Name = "select_MenuItem";
            this.select_MenuItem.Size = new System.Drawing.Size(120, 20);
            this.select_MenuItem.Text = "Тип исследования";
            // 
            // регрессионоеИсследованиеToolStripMenuItem
            // 
            this.регрессионоеИсследованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.определитьПрименимыйМетодToolStripMenuItem1,
            this.простаяЛинейнаяРегрессияToolStripMenuItem,
            this.множественнаяЛинейнаяРегрессияToolStripMenuItem,
            this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem});
            this.регрессионоеИсследованиеToolStripMenuItem.Name = "регрессионоеИсследованиеToolStripMenuItem";
            this.регрессионоеИсследованиеToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.регрессионоеИсследованиеToolStripMenuItem.Text = "Регрессионное исследование";
            // 
            // определитьПрименимыйМетодToolStripMenuItem1
            // 
            this.определитьПрименимыйМетодToolStripMenuItem1.Name = "определитьПрименимыйМетодToolStripMenuItem1";
            this.определитьПрименимыйМетодToolStripMenuItem1.Size = new System.Drawing.Size(345, 22);
            this.определитьПрименимыйМетодToolStripMenuItem1.Text = "Определить применимый метод";
            this.определитьПрименимыйМетодToolStripMenuItem1.Click += new System.EventHandler(this.определитьПрименимыйМетодToolStripMenuItem1_Click);
            // 
            // простаяЛинейнаяРегрессияToolStripMenuItem
            // 
            this.простаяЛинейнаяРегрессияToolStripMenuItem.Name = "простаяЛинейнаяРегрессияToolStripMenuItem";
            this.простаяЛинейнаяРегрессияToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.простаяЛинейнаяРегрессияToolStripMenuItem.Text = "Простая линейная регрессия";
            this.простаяЛинейнаяРегрессияToolStripMenuItem.Click += new System.EventHandler(this.простаяЛинейнаяРегрессияToolStripMenuItem_Click);
            // 
            // множественнаяЛинейнаяРегрессияToolStripMenuItem
            // 
            this.множественнаяЛинейнаяРегрессияToolStripMenuItem.Name = "множественнаяЛинейнаяРегрессияToolStripMenuItem";
            this.множественнаяЛинейнаяРегрессияToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.множественнаяЛинейнаяРегрессияToolStripMenuItem.Text = "Множественная линейная регрессия";
            this.множественнаяЛинейнаяРегрессияToolStripMenuItem.Click += new System.EventHandler(this.множественнаяЛинейнаяРегрессияToolStripMenuItem_Click);
            // 
            // посмотретьИсториюПредварительногоАнализаToolStripMenuItem
            // 
            this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem.Name = "посмотретьИсториюПредварительногоАнализаToolStripMenuItem";
            this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem.Size = new System.Drawing.Size(345, 22);
            this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem.Text = "Посмотреть историю предварительного анализа";
            this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem.Click += new System.EventHandler(this.посмотретьИсториюПредварительногоАнализаToolStripMenuItem_Click);
            // 
            // корреToolStripMenuItem
            // 
            this.корреToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опредеToolStripMenuItem,
            this.произведениеМоментовПирсонаToolStripMenuItem1,
            this.ранговаяКорреляцияСпирменаToolStripMenuItem,
            this.точечнобисеральныйToolStripMenuItem,
            this.бисеToolStripMenuItem,
            this.ранговобисериальныйToolStripMenuItem1,
            this.тетрахорическийToolStripMenuItem1});
            this.корреToolStripMenuItem.Name = "корреToolStripMenuItem";
            this.корреToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.корреToolStripMenuItem.Text = "Корреляционное исследование";
            // 
            // опредеToolStripMenuItem
            // 
            this.опредеToolStripMenuItem.Name = "опредеToolStripMenuItem";
            this.опредеToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.опредеToolStripMenuItem.Text = "Определить метод исследования";
            this.опредеToolStripMenuItem.Click += new System.EventHandler(this.опредеToolStripMenuItem_Click);
            // 
            // произведениеМоментовПирсонаToolStripMenuItem1
            // 
            this.произведениеМоментовПирсонаToolStripMenuItem1.Name = "произведениеМоментовПирсонаToolStripMenuItem1";
            this.произведениеМоментовПирсонаToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.произведениеМоментовПирсонаToolStripMenuItem1.Text = "Произведение моментов Пирсона";
            this.произведениеМоментовПирсонаToolStripMenuItem1.Click += new System.EventHandler(this.произведениеМоментовПирсонаToolStripMenuItem1_Click);
            // 
            // ранговаяКорреляцияСпирменаToolStripMenuItem
            // 
            this.ранговаяКорреляцияСпирменаToolStripMenuItem.Name = "ранговаяКорреляцияСпирменаToolStripMenuItem";
            this.ранговаяКорреляцияСпирменаToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.ранговаяКорреляцияСпирменаToolStripMenuItem.Text = "Ранговая корреляция Спирмена";
            this.ранговаяКорреляцияСпирменаToolStripMenuItem.Click += new System.EventHandler(this.ранговаяКорреляцияСпирменаToolStripMenuItem_Click);
            // 
            // точечнобисеральныйToolStripMenuItem
            // 
            this.точечнобисеральныйToolStripMenuItem.Name = "точечнобисеральныйToolStripMenuItem";
            this.точечнобисеральныйToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.точечнобисеральныйToolStripMenuItem.Text = "Точечно-бисериальный";
            this.точечнобисеральныйToolStripMenuItem.Click += new System.EventHandler(this.точечнобисеральныйToolStripMenuItem_Click);
            // 
            // бисеToolStripMenuItem
            // 
            this.бисеToolStripMenuItem.Name = "бисеToolStripMenuItem";
            this.бисеToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.бисеToolStripMenuItem.Text = "Бисериальный";
            this.бисеToolStripMenuItem.Click += new System.EventHandler(this.бисеToolStripMenuItem_Click);
            // 
            // ранговобисериальныйToolStripMenuItem1
            // 
            this.ранговобисериальныйToolStripMenuItem1.Name = "ранговобисериальныйToolStripMenuItem1";
            this.ранговобисериальныйToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.ранговобисериальныйToolStripMenuItem1.Text = "Рангово-бисериальный";
            this.ранговобисериальныйToolStripMenuItem1.Click += new System.EventHandler(this.ранговобисериальныйToolStripMenuItem1_Click);
            // 
            // тетрахорическийToolStripMenuItem1
            // 
            this.тетрахорическийToolStripMenuItem1.Name = "тетрахорическийToolStripMenuItem1";
            this.тетрахорическийToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.тетрахорическийToolStripMenuItem1.Text = "Тетрахорический";
            this.тетрахорическийToolStripMenuItem1.Click += new System.EventHandler(this.тетрахорическийToolStripMenuItem1_Click);
            // 
            // Help_About_MenuItem
            // 
            this.Help_About_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_MenuItem,
            this.About_MenuItem});
            this.Help_About_MenuItem.Name = "Help_About_MenuItem";
            this.Help_About_MenuItem.Size = new System.Drawing.Size(68, 20);
            this.Help_About_MenuItem.Text = "Помощь";
            // 
            // Help_MenuItem
            // 
            this.Help_MenuItem.Image = global::Ocenka_mer_svyzei.Properties.Resources.help;
            this.Help_MenuItem.Name = "Help_MenuItem";
            this.Help_MenuItem.Size = new System.Drawing.Size(158, 22);
            this.Help_MenuItem.Text = "Справка";
            this.Help_MenuItem.Click += new System.EventHandler(this.Help_MenuItem_Click);
            // 
            // About_MenuItem
            // 
            this.About_MenuItem.Name = "About_MenuItem";
            this.About_MenuItem.Size = new System.Drawing.Size(158, 22);
            this.About_MenuItem.Text = "О программе...";
            this.About_MenuItem.Click += new System.EventHandler(this.About_MenuItem_Click);
            // 
            // mdi_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 676);
            this.Controls.Add(this.main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mdi_form";
            this.Text = "Статистический анализ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem select_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_About_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem регрессионоеИсследованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem определитьПрименимыйМетодToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem корреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опредеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem произведениеМоментовПирсонаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ранговаяКорреляцияСпирменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечнобисеральныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бисеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ранговобисериальныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem тетрахорическийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem простаяЛинейнаяРегрессияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem множественнаяЛинейнаяРегрессияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьИсториюПредварительногоАнализаToolStripMenuItem;
    }
}

