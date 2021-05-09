namespace Ocenka_mer_svyzei
{
    partial class LogisticRegress
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChiSquare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeviance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLogLikelihood = new System.Windows.Forms.TextBox();
            this.dgvLogisticCoefficients = new System.Windows.Forms.DataGridView();
            this.colComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEigenValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSingularValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOddsRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfidenceMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfidenceMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LikelihoodRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.Button();
            this.File_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_File = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogisticCoefficients)).BeginInit();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 437);
            this.dataGridView1.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(820, 443);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Significant";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Log Likelihood";
            // 
            // tbPValue
            // 
            this.tbPValue.Location = new System.Drawing.Point(714, 440);
            this.tbPValue.Name = "tbPValue";
            this.tbPValue.ReadOnly = true;
            this.tbPValue.Size = new System.Drawing.Size(100, 20);
            this.tbPValue.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "-2 Log Likelihood (deviance)";
            // 
            // tbChiSquare
            // 
            this.tbChiSquare.Location = new System.Drawing.Point(608, 440);
            this.tbChiSquare.Name = "tbChiSquare";
            this.tbChiSquare.ReadOnly = true;
            this.tbChiSquare.Size = new System.Drawing.Size(100, 20);
            this.tbChiSquare.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chi-Square Goodness Of Fit";
            // 
            // tbDeviance
            // 
            this.tbDeviance.Location = new System.Drawing.Point(608, 414);
            this.tbDeviance.Name = "tbDeviance";
            this.tbDeviance.ReadOnly = true;
            this.tbDeviance.Size = new System.Drawing.Size(100, 20);
            this.tbDeviance.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(741, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "P-Value";
            // 
            // tbLogLikelihood
            // 
            this.tbLogLikelihood.Enabled = false;
            this.tbLogLikelihood.Location = new System.Drawing.Point(608, 388);
            this.tbLogLikelihood.Name = "tbLogLikelihood";
            this.tbLogLikelihood.ReadOnly = true;
            this.tbLogLikelihood.Size = new System.Drawing.Size(100, 20);
            this.tbLogLikelihood.TabIndex = 28;
            // 
            // dgvLogisticCoefficients
            // 
            this.dgvLogisticCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogisticCoefficients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colComponent,
            this.colEigenValue,
            this.colSingularValue,
            this.colOddsRatio,
            this.colConfidenceMax,
            this.colConfidenceMin,
            this.colProportion,
            this.LikelihoodRatio});
            this.dgvLogisticCoefficients.Location = new System.Drawing.Point(438, 27);
            this.dgvLogisticCoefficients.Name = "dgvLogisticCoefficients";
            this.dgvLogisticCoefficients.Size = new System.Drawing.Size(845, 355);
            this.dgvLogisticCoefficients.TabIndex = 30;
            // 
            // colComponent
            // 
            this.colComponent.HeaderText = "Name";
            this.colComponent.Name = "colComponent";
            // 
            // colEigenValue
            // 
            this.colEigenValue.HeaderText = "Value";
            this.colEigenValue.Name = "colEigenValue";
            // 
            // colSingularValue
            // 
            this.colSingularValue.HeaderText = "StandardError";
            this.colSingularValue.Name = "colSingularValue";
            // 
            // colOddsRatio
            // 
            this.colOddsRatio.HeaderText = "OddsRatio";
            this.colOddsRatio.Name = "colOddsRatio";
            // 
            // colConfidenceMax
            // 
            this.colConfidenceMax.HeaderText = "ConfidenceUpper";
            this.colConfidenceMax.Name = "colConfidenceMax";
            // 
            // colConfidenceMin
            // 
            this.colConfidenceMin.HeaderText = "ConfidenceLower";
            this.colConfidenceMin.Name = "colConfidenceMin";
            // 
            // colProportion
            // 
            this.colProportion.HeaderText = "Wald p-Value";
            this.colProportion.Name = "colProportion";
            // 
            // LikelihoodRatio
            // 
            this.LikelihoodRatio.HeaderText = "Likelihood-Ratio p-Value";
            this.LikelihoodRatio.Name = "LikelihoodRatio";
            // 
            // Run
            // 
            this.Run.Enabled = false;
            this.Run.Location = new System.Drawing.Point(940, 391);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(148, 65);
            this.Run.TabIndex = 31;
            this.Run.Text = "Рассчитать";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
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
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1291, 24);
            this.main_menu.TabIndex = 19;
            this.main_menu.Text = "menuStrip1";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // LogisticRegress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 476);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.dgvLogisticCoefficients);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChiSquare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDeviance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLogLikelihood);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.main_menu);
            this.Name = "LogisticRegress";
            this.Text = "LogisticRegress";
            this.Load += new System.EventHandler(this.LogisticRegress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogisticCoefficients)).EndInit();
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChiSquare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeviance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLogLikelihood;
        private System.Windows.Forms.DataGridView dgvLogisticCoefficients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEigenValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSingularValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOddsRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfidenceMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfidenceMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LikelihoodRatio;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.ToolStripMenuItem File_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFD_File;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}