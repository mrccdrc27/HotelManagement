namespace NOAKAY.DASHFORM
{
    partial class DashboardRoom
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlOverview = new Panel();
            label1 = new Label();
            label2 = new Label();
            pnlRoomList = new Panel();
            dgvRoomList = new Guna.UI2.WinForms.Guna2DataGridView();
            roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlOverview
            // 
            pnlOverview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlOverview.BackColor = Color.FromArgb(204, 227, 222);
            pnlOverview.Location = new Point(30, 61);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Size = new Size(1058, 190);
            pnlOverview.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 1;
            label1.Text = "Overview";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 58, 64);
            label2.Location = new Point(30, 283);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 2;
            label2.Text = "Room List";
            // 
            // pnlRoomList
            // 
            pnlRoomList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRoomList.BackColor = Color.FromArgb(204, 227, 222);
            pnlRoomList.Location = new Point(30, 321);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(1058, 388);
            pnlRoomList.TabIndex = 3;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AllowUserToAddRows = false;
            dgvRoomList.AllowUserToDeleteRows = false;
            dgvRoomList.AllowUserToResizeColumns = false;
            dgvRoomList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvRoomList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRoomList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoomList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRoomList.ColumnHeadersHeight = 22;
            dgvRoomList.Columns.AddRange(new DataGridViewColumn[] { roomIDDataGridViewTextBoxColumn, roomStatusDataGridViewTextBoxColumn, roomNumDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn });
            dgvRoomList.DataSource = roomModelBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRoomList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRoomList.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomList.Location = new Point(30, 321);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.ReadOnly = true;
            dgvRoomList.RowHeadersVisible = false;
            dgvRoomList.RowHeadersWidth = 51;
            dgvRoomList.Size = new Size(1058, 388);
            dgvRoomList.TabIndex = 1;
            dgvRoomList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRoomList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRoomList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRoomList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRoomList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRoomList.ThemeStyle.BackColor = Color.White;
            dgvRoomList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRoomList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRoomList.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRoomList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRoomList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRoomList.ThemeStyle.HeaderStyle.Height = 22;
            dgvRoomList.ThemeStyle.ReadOnly = true;
            dgvRoomList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRoomList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoomList.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRoomList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRoomList.ThemeStyle.RowsStyle.Height = 29;
            dgvRoomList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRoomList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomStatusDataGridViewTextBoxColumn
            // 
            roomStatusDataGridViewTextBoxColumn.DataPropertyName = "RoomStatus";
            roomStatusDataGridViewTextBoxColumn.HeaderText = "RoomStatus";
            roomStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomStatusDataGridViewTextBoxColumn.Name = "roomStatusDataGridViewTextBoxColumn";
            roomStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            roomNumDataGridViewTextBoxColumn.HeaderText = "RoomNum";
            roomNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            roomNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomModelBindingSource
            // 
            roomModelBindingSource.DataSource = typeof(CLASSES.RoomModel);
            // 
            // DashboardRoom
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(dgvRoomList);
            Controls.Add(pnlRoomList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlOverview);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardRoom";
            Text = "DashboardRoom";
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlOverview;
        private Label label1;
        private Label label2;
        private Panel pnlRoomList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoomList;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private BindingSource roomModelBindingSource;
    }
}