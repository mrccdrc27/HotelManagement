namespace NOAKAY.DASHFORM
{
    partial class DashboardGenerateReport
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
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            invoiceBindingSource = new BindingSource(components);
            label2 = new Label();
            dtpRoomStart = new DateTimePicker();
            dtpRoomEnd = new DateTimePicker();
            btnFilterRoom = new Button();
            btnPrintRoomReport = new Button();
            btnPrintGuestReport = new Button();
            btnFilterGuest = new Button();
            dtpGuestEnd = new DateTimePicker();
            dtpGuestStart = new DateTimePicker();
            label3 = new Label();
            dgvGuestList = new Guna.UI2.WinForms.Guna2DataGridView();
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
            guestRoomCategoryDTOBindingSource = new BindingSource(components);
            label4 = new Label();
            roomName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            gueststatus = new DataGridViewTextBoxColumn();
            checkIn = new DataGridViewTextBoxColumn();
            checkOut = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 4;
            label1.Text = "ROOM REPORT";
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.AllowUserToResizeColumns = false;
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 44;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { roomName, fullName, gueststatus, checkIn, checkOut, price });
            guna2DataGridView1.DataSource = invoiceBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(23, 70);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(1068, 188);
            guna2DataGridView1.TabIndex = 5;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 44;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // invoiceBindingSource
            // 
            invoiceBindingSource.DataSource = typeof(CLASSES.Joined_Tables.Invoice);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 284);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 7;
            label2.Text = "Filter by month";
            // 
            // dtpRoomStart
            // 
            dtpRoomStart.Location = new Point(177, 278);
            dtpRoomStart.Name = "dtpRoomStart";
            dtpRoomStart.Size = new Size(250, 26);
            dtpRoomStart.TabIndex = 8;
            // 
            // dtpRoomEnd
            // 
            dtpRoomEnd.Location = new Point(452, 278);
            dtpRoomEnd.Name = "dtpRoomEnd";
            dtpRoomEnd.Size = new Size(250, 26);
            dtpRoomEnd.TabIndex = 9;
            // 
            // btnFilterRoom
            // 
            btnFilterRoom.BackColor = Color.MediumTurquoise;
            btnFilterRoom.FlatStyle = FlatStyle.Flat;
            btnFilterRoom.ForeColor = SystemColors.ControlText;
            btnFilterRoom.Location = new Point(853, 280);
            btnFilterRoom.Name = "btnFilterRoom";
            btnFilterRoom.Size = new Size(111, 28);
            btnFilterRoom.TabIndex = 10;
            btnFilterRoom.Text = "Filter";
            btnFilterRoom.UseVisualStyleBackColor = false;
            btnFilterRoom.Click += btnFilterRoom_Click;
            // 
            // btnPrintRoomReport
            // 
            btnPrintRoomReport.BackColor = Color.Firebrick;
            btnPrintRoomReport.FlatStyle = FlatStyle.Flat;
            btnPrintRoomReport.ForeColor = SystemColors.ControlText;
            btnPrintRoomReport.Location = new Point(984, 280);
            btnPrintRoomReport.Name = "btnPrintRoomReport";
            btnPrintRoomReport.Size = new Size(107, 28);
            btnPrintRoomReport.TabIndex = 11;
            btnPrintRoomReport.Text = "Print";
            btnPrintRoomReport.UseVisualStyleBackColor = false;
            btnPrintRoomReport.Click += btnPrintRoomReport_Click;
            // 
            // btnPrintGuestReport
            // 
            btnPrintGuestReport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPrintGuestReport.BackColor = Color.Firebrick;
            btnPrintGuestReport.FlatStyle = FlatStyle.Flat;
            btnPrintGuestReport.ForeColor = SystemColors.ControlText;
            btnPrintGuestReport.Location = new Point(984, 597);
            btnPrintGuestReport.Name = "btnPrintGuestReport";
            btnPrintGuestReport.Size = new Size(107, 28);
            btnPrintGuestReport.TabIndex = 18;
            btnPrintGuestReport.Text = "Print";
            btnPrintGuestReport.UseVisualStyleBackColor = false;
            btnPrintGuestReport.Click += btnPrintGuestReport_Click;
            // 
            // btnFilterGuest
            // 
            btnFilterGuest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnFilterGuest.BackColor = Color.MediumTurquoise;
            btnFilterGuest.FlatStyle = FlatStyle.Flat;
            btnFilterGuest.ForeColor = SystemColors.ControlText;
            btnFilterGuest.Location = new Point(853, 597);
            btnFilterGuest.Name = "btnFilterGuest";
            btnFilterGuest.Size = new Size(111, 28);
            btnFilterGuest.TabIndex = 17;
            btnFilterGuest.Text = "Filter";
            btnFilterGuest.UseVisualStyleBackColor = false;
            btnFilterGuest.Click += btnFilterGuest_Click;
            // 
            // dtpGuestEnd
            // 
            dtpGuestEnd.Location = new Point(452, 595);
            dtpGuestEnd.Name = "dtpGuestEnd";
            dtpGuestEnd.Size = new Size(250, 26);
            dtpGuestEnd.TabIndex = 16;
            // 
            // dtpGuestStart
            // 
            dtpGuestStart.Location = new Point(177, 595);
            dtpGuestStart.Name = "dtpGuestStart";
            dtpGuestStart.Size = new Size(250, 26);
            dtpGuestStart.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(23, 601);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 14;
            label3.Text = "Filter by month";
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AllowUserToDeleteRows = false;
            dgvGuestList.AllowUserToResizeColumns = false;
            dgvGuestList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvGuestList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGuestList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGuestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGuestList.ColumnHeadersHeight = 44;
            dgvGuestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvGuestList.Columns.AddRange(new DataGridViewColumn[] { guestIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, suffixDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, contactDataGridViewTextBoxColumn, guestStatusDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, roomIDDataGridViewTextBoxColumn, roomNumDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn });
            dgvGuestList.DataSource = guestRoomCategoryDTOBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGuestList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGuestList.GridColor = Color.FromArgb(231, 229, 255);
            dgvGuestList.Location = new Point(23, 387);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.ReadOnly = true;
            dgvGuestList.RowHeadersVisible = false;
            dgvGuestList.RowHeadersWidth = 51;
            dgvGuestList.Size = new Size(1068, 188);
            dgvGuestList.TabIndex = 13;
            dgvGuestList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvGuestList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvGuestList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvGuestList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvGuestList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvGuestList.ThemeStyle.BackColor = Color.White;
            dgvGuestList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGuestList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvGuestList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGuestList.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvGuestList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvGuestList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvGuestList.ThemeStyle.HeaderStyle.Height = 44;
            dgvGuestList.ThemeStyle.ReadOnly = true;
            dgvGuestList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGuestList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuestList.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvGuestList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvGuestList.ThemeStyle.RowsStyle.Height = 29;
            dgvGuestList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGuestList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // guestRoomCategoryDTOBindingSource
            // 
            guestRoomCategoryDTOBindingSource.DataSource = typeof(CLASSES.Joined_Tables.GuestRoomCategoryDTO);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(55, 58, 64);
            label4.Location = new Point(23, 342);
            label4.Name = "label4";
            label4.Size = new Size(234, 23);
            label4.TabIndex = 12;
            label4.Text = "GUEST DEMOGRAPHICS";
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
            // gueststatus
            // 
            gueststatus.DataPropertyName = "gueststatus";
            gueststatus.HeaderText = "gueststatus";
            gueststatus.MinimumWidth = 6;
            gueststatus.Name = "gueststatus";
            gueststatus.ReadOnly = true;
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
            // DashboardGenerateReport
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1119, 738);
            Controls.Add(btnPrintGuestReport);
            Controls.Add(btnFilterGuest);
            Controls.Add(dtpGuestEnd);
            Controls.Add(dtpGuestStart);
            Controls.Add(label3);
            Controls.Add(dgvGuestList);
            Controls.Add(label4);
            Controls.Add(btnPrintRoomReport);
            Controls.Add(btnFilterRoom);
            Controls.Add(dtpRoomEnd);
            Controls.Add(dtpRoomStart);
            Controls.Add(label2);
            Controls.Add(guna2DataGridView1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardGenerateReport";
            Text = "DashboardGenerateReport";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label label2;
        private DateTimePicker dtpRoomStart;
        private DateTimePicker dtpRoomEnd;
        private Button btnFilterRoom;
        private Button btnPrintRoomReport;
        private Button btnPrintGuestReport;
        private Button btnFilterGuest;
        private DateTimePicker dtpGuestEnd;
        private DateTimePicker dtpGuestStart;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGuestList;
        private Label label4;
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
        private BindingSource guestRoomCategoryDTOBindingSource;
        private BindingSource invoiceBindingSource;
        private DataGridViewTextBoxColumn roomName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn gueststatus;
        private DataGridViewTextBoxColumn checkIn;
        private DataGridViewTextBoxColumn checkOut;
        private DataGridViewTextBoxColumn price;
    }
}