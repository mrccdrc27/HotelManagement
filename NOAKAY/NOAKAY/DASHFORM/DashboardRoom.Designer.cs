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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlOverview = new Panel();
            label1 = new Label();
            label2 = new Label();
            pnlRoomList = new Panel();
            dgvRoomList = new Guna.UI2.WinForms.Guna2DataGridView();
            roomGuestModelBindingSource = new BindingSource(components);
            roomCategoryDTOBindingSource = new BindingSource(components);
            roomModelBindingSource = new BindingSource(components);
            btnUpdateRStatus = new Button();
            RoomId = new DataGridViewTextBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomGuestModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomCategoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlOverview
            // 
            pnlOverview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlOverview.BackColor = Color.FromArgb(204, 227, 222);
            pnlOverview.Location = new Point(30, 61);
            pnlOverview.Name = "pnlOverview";
            pnlOverview.Size = new Size(874, 190);
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
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRoomList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoomList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoomList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoomList.ColumnHeadersHeight = 22;
            dgvRoomList.Columns.AddRange(new DataGridViewColumn[] { RoomId, GuestID, Status });
            dgvRoomList.DataSource = roomGuestModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoomList.DefaultCellStyle = dataGridViewCellStyle3;
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
            // roomGuestModelBindingSource
            // 
            roomGuestModelBindingSource.DataSource = typeof(CLASSES.RoomGuestModel);
            // 
            // roomCategoryDTOBindingSource
            // 
            roomCategoryDTOBindingSource.DataSource = typeof(CLASSES.Joined_Tables.RoomCategoryDTO);
            // 
            // roomModelBindingSource
            // 
            roomModelBindingSource.DataSource = typeof(CLASSES.RoomModel);
            // 
            // btnUpdateRStatus
            // 
            btnUpdateRStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateRStatus.BackColor = Color.FromArgb(107, 144, 128);
            btnUpdateRStatus.FlatAppearance.BorderSize = 0;
            btnUpdateRStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateRStatus.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateRStatus.ForeColor = Color.FromArgb(246, 255, 248);
            btnUpdateRStatus.Location = new Point(937, 61);
            btnUpdateRStatus.Name = "btnUpdateRStatus";
            btnUpdateRStatus.Size = new Size(151, 33);
            btnUpdateRStatus.TabIndex = 21;
            btnUpdateRStatus.Text = "Update Room";
            btnUpdateRStatus.UseVisualStyleBackColor = false;
            btnUpdateRStatus.Click += btnUpdateRStatus_Click;
            // 
            // RoomId
            // 
            RoomId.DataPropertyName = "RoomId";
            RoomId.HeaderText = "RoomId";
            RoomId.MinimumWidth = 6;
            RoomId.Name = "RoomId";
            RoomId.ReadOnly = true;
            // 
            // GuestID
            // 
            GuestID.DataPropertyName = "GuestID";
            GuestID.HeaderText = "GuestID";
            GuestID.MinimumWidth = 6;
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // DashboardRoom
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(btnUpdateRStatus);
            Controls.Add(dgvRoomList);
            Controls.Add(pnlRoomList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlOverview);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardRoom";
            Text = "DashboardRoom";
            Load += DashboardRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomGuestModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomCategoryDTOBindingSource).EndInit();
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
        private BindingSource roomModelBindingSource;
        private BindingSource roomGuestModelBindingSource;
        private Button btnUpdateRStatus;
        private BindingSource roomCategoryDTOBindingSource;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn Status;
    }
}