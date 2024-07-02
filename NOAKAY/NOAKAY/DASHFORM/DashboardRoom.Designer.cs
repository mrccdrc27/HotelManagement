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
            RoomId = new DataGridViewTextBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            roomGuestModelBindingSource = new BindingSource(components);
            roomCategoryDTOBindingSource = new BindingSource(components);
            roomModelBindingSource = new BindingSource(components);
            btnUpdateRStatus = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
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
            label1.Size = new Size(82, 19);
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
            label2.Size = new Size(79, 19);
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
            dgvRoomList.Columns.AddRange(new DataGridViewColumn[] { RoomId, GuestID, Status, roomIdDataGridViewTextBoxColumn, guestIDDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn });
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
            dgvRoomList.RowTemplate.Height = 29;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Current", "Between" });
            comboBox1.Location = new Point(555, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(336, 284);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 22);
            dateTimePicker2.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 264);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(59, 17);
            label3.TabIndex = 25;
            label3.Text = "Check In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 264);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 26;
            label4.Text = "Check Out";
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "CheckIn";
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            checkOutDataGridViewTextBoxColumn.HeaderText = "CheckOut";
            checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(694, 283);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DashboardRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private Button button1;
    }
}