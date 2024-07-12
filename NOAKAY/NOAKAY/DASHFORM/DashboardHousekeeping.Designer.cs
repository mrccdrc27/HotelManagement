namespace NOAKAY.DASHFORM
{
    partial class DashboardHousekeeping
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
            panel1 = new Panel();
            label5 = new Label();
            dgvImportFiles = new DataGridView();
            btnImportCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImportFiles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 79, 82);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 47);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(55, 58, 64);
            label5.Location = new Point(31, 95);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 4;
            label5.Text = "Import ";
            // 
            // dgvImportFiles
            // 
            dgvImportFiles.AllowUserToAddRows = false;
            dgvImportFiles.AllowUserToDeleteRows = false;
            dgvImportFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportFiles.Location = new Point(31, 151);
            dgvImportFiles.Name = "dgvImportFiles";
            dgvImportFiles.ReadOnly = true;
            dgvImportFiles.RowHeadersWidth = 51;
            dgvImportFiles.Size = new Size(1060, 288);
            dgvImportFiles.TabIndex = 5;
            // 
            // btnImportCSV
            // 
            btnImportCSV.Location = new Point(132, 95);
            btnImportCSV.Name = "btnImportCSV";
            btnImportCSV.Size = new Size(145, 29);
            btnImportCSV.TabIndex = 6;
            btnImportCSV.Text = "Import CSV";
            btnImportCSV.UseVisualStyleBackColor = true;
            btnImportCSV.Click += btnImportCSV_Click;
            // 
            // DashboardHousekeeping
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 691);
            Controls.Add(btnImportCSV);
            Controls.Add(dgvImportFiles);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardHousekeeping";
            Text = "DashboardHousekeeping";
            ((System.ComponentModel.ISupportInitialize)dgvImportFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private DataGridView dgvImportFiles;
        private Button btnImportCSV;
    }
}