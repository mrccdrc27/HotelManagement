namespace NOAKAY.DASHFORM
{
    partial class DashboardGenerateRoomReport
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            dgvRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            roomName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            checkIn = new DataGridViewTextBoxColumn();
            checkOut = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            guestIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            categoryIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            gueststatusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            invoiceBindingSource = new BindingSource(components);
            label2 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnFilterRoom = new Button();
            btnPrintRoomReport = new Button();
            panel3 = new Panel();
            label3 = new Label();
            lblTotalStandard = new Label();
            lblTotalDeluxe = new Label();
            label5 = new Label();
            lblTotalSuite = new Label();
            label7 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            guestRoomCategoryDTOBindingSource = new BindingSource(components);
            panel6 = new Panel();
            label8 = new Label();
            dgvGuest = new Guna.UI2.WinForms.Guna2DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Suffix = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            RoomNum = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            guestIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suffixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dtpEndGuest = new DateTimePicker();
            dtpStartGuest = new DateTimePicker();
            label4 = new Label();
            btnPrintGuestReport = new Button();
            btnFilterGuest = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 3;
            label1.Text = "ROOM REPORT";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Teal;
            panel1.Location = new Point(35, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 45);
            panel1.TabIndex = 4;
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dgvRoom.AllowUserToResizeColumns = false;
            dgvRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoom.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoom.ColumnHeadersHeight = 29;
            dgvRoom.Columns.AddRange(new DataGridViewColumn[] { roomName, fullName, status, checkIn, checkOut, price, guestIDDataGridViewTextBoxColumn1, categoryIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, roomNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn1, checkOutDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn1, gueststatusDataGridViewTextBoxColumn1 });
            dgvRoom.DataSource = invoiceBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoom.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRoom.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoom.Location = new Point(35, 123);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.RowHeadersWidth = 51;
            dgvRoom.Size = new Size(1016, 158);
            dgvRoom.TabIndex = 0;
            dgvRoom.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRoom.ThemeStyle.BackColor = Color.White;
            dgvRoom.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoom.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRoom.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRoom.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRoom.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRoom.ThemeStyle.HeaderStyle.Height = 29;
            dgvRoom.ThemeStyle.ReadOnly = true;
            dgvRoom.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRoom.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoom.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRoom.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlLightLight;
            dgvRoom.ThemeStyle.RowsStyle.Height = 29;
            dgvRoom.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRoom.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // roomName
            // 
            roomName.DataPropertyName = "roomName";
            roomName.HeaderText = "roomName";
            roomName.MinimumWidth = 6;
            roomName.Name = "roomName";
            roomName.ReadOnly = true;
            // 
            // fullName
            // 
            fullName.DataPropertyName = "fullName";
            fullName.HeaderText = "fullName";
            fullName.MinimumWidth = 6;
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // checkIn
            // 
            checkIn.DataPropertyName = "checkIn";
            checkIn.HeaderText = "checkIn";
            checkIn.MinimumWidth = 6;
            checkIn.Name = "checkIn";
            checkIn.ReadOnly = true;
            // 
            // checkOut
            // 
            checkOut.DataPropertyName = "checkOut";
            checkOut.HeaderText = "checkOut";
            checkOut.MinimumWidth = 6;
            checkOut.Name = "checkOut";
            checkOut.ReadOnly = true;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            price.HeaderText = "price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn1
            // 
            guestIDDataGridViewTextBoxColumn1.DataPropertyName = "guestID";
            guestIDDataGridViewTextBoxColumn1.HeaderText = "guestID";
            guestIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            guestIDDataGridViewTextBoxColumn1.Name = "guestIDDataGridViewTextBoxColumn1";
            guestIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            categoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID";
            categoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID";
            categoryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            roomNameDataGridViewTextBoxColumn.HeaderText = "roomName";
            roomNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn1
            // 
            checkInDataGridViewTextBoxColumn1.DataPropertyName = "checkIn";
            checkInDataGridViewTextBoxColumn1.HeaderText = "checkIn";
            checkInDataGridViewTextBoxColumn1.MinimumWidth = 6;
            checkInDataGridViewTextBoxColumn1.Name = "checkInDataGridViewTextBoxColumn1";
            checkInDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn1
            // 
            checkOutDataGridViewTextBoxColumn1.DataPropertyName = "checkOut";
            checkOutDataGridViewTextBoxColumn1.HeaderText = "checkOut";
            checkOutDataGridViewTextBoxColumn1.MinimumWidth = 6;
            checkOutDataGridViewTextBoxColumn1.Name = "checkOutDataGridViewTextBoxColumn1";
            checkOutDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn1.HeaderText = "status";
            statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gueststatusDataGridViewTextBoxColumn1
            // 
            gueststatusDataGridViewTextBoxColumn1.DataPropertyName = "gueststatus";
            gueststatusDataGridViewTextBoxColumn1.HeaderText = "gueststatus";
            gueststatusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            gueststatusDataGridViewTextBoxColumn1.Name = "gueststatusDataGridViewTextBoxColumn1";
            gueststatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // invoiceBindingSource
            // 
            invoiceBindingSource.DataSource = typeof(CLASSES.Joined_Tables.Invoice);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(11, 12);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 6;
            label2.Text = "Filter by month";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(163, 12);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 26);
            dtpStart.TabIndex = 7;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(419, 12);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 26);
            dtpEnd.TabIndex = 8;
            // 
            // btnFilterRoom
            // 
            btnFilterRoom.BackColor = Color.MediumTurquoise;
            btnFilterRoom.FlatStyle = FlatStyle.Flat;
            btnFilterRoom.ForeColor = SystemColors.ControlText;
            btnFilterRoom.Location = new Point(792, 12);
            btnFilterRoom.Name = "btnFilterRoom";
            btnFilterRoom.Size = new Size(111, 28);
            btnFilterRoom.TabIndex = 9;
            btnFilterRoom.Text = "Filter";
            btnFilterRoom.UseVisualStyleBackColor = false;
            btnFilterRoom.Click += btnFilterRoom_Click;
            // 
            // btnPrintRoomReport
            // 
            btnPrintRoomReport.BackColor = Color.Firebrick;
            btnPrintRoomReport.FlatStyle = FlatStyle.Flat;
            btnPrintRoomReport.ForeColor = SystemColors.ControlText;
            btnPrintRoomReport.Location = new Point(909, 12);
            btnPrintRoomReport.Name = "btnPrintRoomReport";
            btnPrintRoomReport.Size = new Size(107, 28);
            btnPrintRoomReport.TabIndex = 10;
            btnPrintRoomReport.Text = "Print";
            btnPrintRoomReport.UseVisualStyleBackColor = false;
            btnPrintRoomReport.Click += btnPrintRoomReport_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dtpStart);
            panel3.Controls.Add(dtpEnd);
            panel3.Controls.Add(btnFilterRoom);
            panel3.Controls.Add(btnPrintRoomReport);
            panel3.Location = new Point(35, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(991, 49);
            panel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(55, 58, 64);
            label3.Location = new Point(35, 359);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 12;
            label3.Text = "STANDARD: ";
            // 
            // lblTotalStandard
            // 
            lblTotalStandard.AutoSize = true;
            lblTotalStandard.ForeColor = SystemColors.ControlText;
            lblTotalStandard.Location = new Point(184, 362);
            lblTotalStandard.Name = "lblTotalStandard";
            lblTotalStandard.Size = new Size(17, 20);
            lblTotalStandard.TabIndex = 13;
            lblTotalStandard.Text = "0";
            // 
            // lblTotalDeluxe
            // 
            lblTotalDeluxe.AutoSize = true;
            lblTotalDeluxe.ForeColor = SystemColors.ControlText;
            lblTotalDeluxe.Location = new Point(391, 365);
            lblTotalDeluxe.Name = "lblTotalDeluxe";
            lblTotalDeluxe.Size = new Size(17, 20);
            lblTotalDeluxe.TabIndex = 15;
            lblTotalDeluxe.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(55, 58, 64);
            label5.Location = new Point(242, 362);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 14;
            label5.Text = "DELUXE:";
            // 
            // lblTotalSuite
            // 
            lblTotalSuite.AutoSize = true;
            lblTotalSuite.ForeColor = SystemColors.ControlText;
            lblTotalSuite.Location = new Point(603, 362);
            lblTotalSuite.Name = "lblTotalSuite";
            lblTotalSuite.Size = new Size(17, 20);
            lblTotalSuite.TabIndex = 17;
            lblTotalSuite.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(55, 58, 64);
            label7.Location = new Point(454, 359);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 16;
            label7.Text = "SUITE:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.ControlText;
            lblTotal.Location = new Point(1008, 362);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(17, 20);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(55, 58, 64);
            label6.Location = new Point(859, 359);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 18;
            label6.Text = "TOTAL: ";
            // 
            // guestRoomCategoryDTOBindingSource
            // 
            guestRoomCategoryDTOBindingSource.DataSource = typeof(CLASSES.Joined_Tables.GuestRoomCategoryDTO);
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Teal;
            panel6.Location = new Point(30, 491);
            panel6.Name = "panel6";
            panel6.Size = new Size(1017, 45);
            panel6.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(55, 58, 64);
            label8.Location = new Point(17, 446);
            label8.Name = "label8";
            label8.Size = new Size(234, 23);
            label8.TabIndex = 20;
            label8.Text = "GUEST DEMOGRAPHICS";
            // 
            // dgvGuest
            // 
            dgvGuest.AllowUserToAddRows = false;
            dgvGuest.AllowUserToDeleteRows = false;
            dgvGuest.AllowUserToResizeColumns = false;
            dgvGuest.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvGuest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGuest.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGuest.ColumnHeadersHeight = 29;
            dgvGuest.Columns.AddRange(new DataGridViewColumn[] { FirstName, MiddleName, LastName, Suffix, Email, Contact, RoomNum, CategoryName, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, guestIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, suffixDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, contactDataGridViewTextBoxColumn, guestStatusDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, roomIDDataGridViewTextBoxColumn, roomNumDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn });
            dgvGuest.DataSource = guestRoomCategoryDTOBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGuest.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGuest.GridColor = Color.FromArgb(231, 229, 255);
            dgvGuest.Location = new Point(30, 542);
            dgvGuest.Name = "dgvGuest";
            dgvGuest.ReadOnly = true;
            dgvGuest.RowHeadersVisible = false;
            dgvGuest.RowHeadersWidth = 51;
            dgvGuest.Size = new Size(1038, 158);
            dgvGuest.TabIndex = 0;
            dgvGuest.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvGuest.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvGuest.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvGuest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvGuest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvGuest.ThemeStyle.BackColor = Color.White;
            dgvGuest.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGuest.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvGuest.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGuest.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvGuest.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvGuest.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGuest.ThemeStyle.HeaderStyle.Height = 29;
            dgvGuest.ThemeStyle.ReadOnly = true;
            dgvGuest.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGuest.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuest.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvGuest.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlLightLight;
            dgvGuest.ThemeStyle.RowsStyle.Height = 29;
            dgvGuest.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGuest.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            MiddleName.DataPropertyName = "MiddleName";
            MiddleName.HeaderText = "MiddleName";
            MiddleName.MinimumWidth = 6;
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Suffix
            // 
            Suffix.DataPropertyName = "Suffix";
            Suffix.HeaderText = "Suffix";
            Suffix.MinimumWidth = 6;
            Suffix.Name = "Suffix";
            Suffix.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Contact
            // 
            Contact.DataPropertyName = "Contact";
            Contact.HeaderText = "Contact";
            Contact.MinimumWidth = 6;
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            // 
            // RoomNum
            // 
            RoomNum.DataPropertyName = "RoomNum";
            RoomNum.HeaderText = "RoomNum";
            RoomNum.MinimumWidth = 6;
            RoomNum.Name = "RoomNum";
            RoomNum.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CheckIn";
            dataGridViewTextBoxColumn1.HeaderText = "CheckIn";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CheckOut";
            dataGridViewTextBoxColumn2.HeaderText = "CheckOut";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            guestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            suffixDataGridViewTextBoxColumn.MinimumWidth = 6;
            suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            suffixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestStatusDataGridViewTextBoxColumn
            // 
            guestStatusDataGridViewTextBoxColumn.DataPropertyName = "GuestStatus";
            guestStatusDataGridViewTextBoxColumn.HeaderText = "GuestStatus";
            guestStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            guestStatusDataGridViewTextBoxColumn.Name = "guestStatusDataGridViewTextBoxColumn";
            guestStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            roomNumDataGridViewTextBoxColumn.HeaderText = "RoomNum";
            roomNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            roomNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "CheckIn";
            checkInDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            checkOutDataGridViewTextBoxColumn.HeaderText = "CheckOut";
            checkOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtpEndGuest
            // 
            dtpEndGuest.Location = new Point(419, 12);
            dtpEndGuest.Name = "dtpEndGuest";
            dtpEndGuest.Size = new Size(250, 26);
            dtpEndGuest.TabIndex = 8;
            // 
            // dtpStartGuest
            // 
            dtpStartGuest.Location = new Point(163, 12);
            dtpStartGuest.Name = "dtpStartGuest";
            dtpStartGuest.Size = new Size(250, 26);
            dtpStartGuest.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(11, 12);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 6;
            label4.Text = "Filter by month";
            // 
            // btnPrintGuestReport
            // 
            btnPrintGuestReport.BackColor = Color.Firebrick;
            btnPrintGuestReport.FlatStyle = FlatStyle.Flat;
            btnPrintGuestReport.ForeColor = SystemColors.ControlText;
            btnPrintGuestReport.Location = new Point(914, 13);
            btnPrintGuestReport.Name = "btnPrintGuestReport";
            btnPrintGuestReport.Size = new Size(107, 28);
            btnPrintGuestReport.TabIndex = 12;
            btnPrintGuestReport.Text = "Print";
            btnPrintGuestReport.UseVisualStyleBackColor = false;
            // 
            // btnFilterGuest
            // 
            btnFilterGuest.BackColor = Color.MediumTurquoise;
            btnFilterGuest.FlatStyle = FlatStyle.Flat;
            btnFilterGuest.ForeColor = SystemColors.ControlText;
            btnFilterGuest.Location = new Point(797, 13);
            btnFilterGuest.Name = "btnFilterGuest";
            btnFilterGuest.Size = new Size(111, 28);
            btnFilterGuest.TabIndex = 11;
            btnFilterGuest.Text = "Filter";
            btnFilterGuest.UseVisualStyleBackColor = false;
            btnFilterGuest.Click += btnFilterGuest_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(btnFilterGuest);
            panel4.Controls.Add(btnPrintGuestReport);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(dtpStartGuest);
            panel4.Controls.Add(dtpEndGuest);
            panel4.Location = new Point(30, 706);
            panel4.Name = "panel4";
            panel4.Size = new Size(1017, 49);
            panel4.TabIndex = 23;
            // 
            // DashboardGenerateRoomReport
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(204, 227, 222);
            ClientSize = new Size(1119, 738);
            Controls.Add(dgvRoom);
            Controls.Add(dgvGuest);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(label8);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(lblTotalSuite);
            Controls.Add(label7);
            Controls.Add(lblTotalDeluxe);
            Controls.Add(label5);
            Controls.Add(lblTotalStandard);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardGenerateRoomReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservedString";
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoom;
        private BindingSource invoiceBindingSource;
        private Label label2;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnFilterRoom;
        private Button btnPrintRoomReport;
        private Panel panel3;
        private Label label3;
        private Label lblTotalStandard;
        private Label lblTotalDeluxe;
        private Label label5;
        private Label lblTotalSuite;
        private Label label7;
        private Label lblTotal;
        private Label label6;
        private Panel panel6;
        private Label label8;
        private BindingSource guestRoomCategoryDTOBindingSource;
        private DataGridViewTextBoxColumn roomName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn checkIn;
        private DataGridViewTextBoxColumn checkOut;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn gueststatusDataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGuest;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Suffix;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn RoomNum;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private DateTimePicker dtpEndGuest;
        private DateTimePicker dtpStartGuest;
        private Label label4;
        private Button btnPrintGuestReport;
        private Button btnFilterGuest;
        private Panel panel4;
    }
}