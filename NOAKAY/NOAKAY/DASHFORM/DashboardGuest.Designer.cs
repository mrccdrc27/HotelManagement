namespace NOAKAY.DASHFORM
{
    partial class DashboardGuest
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            pnlGuestList = new Panel();
            dgvGuestList = new Guna.UI2.WinForms.Guna2DataGridView();
            RoomID = new DataGridViewTextBoxColumn();
            RoomNum = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            GuestStatus = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            guestIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suffixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestRoomCategoryDTOBindingSource = new BindingSource(components);
            guestModelBindingSource = new BindingSource(components);
            comboSearchStatus = new ComboBox();
            pnlGuestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 2;
            label1.Text = "Guest List";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(204, 227, 222);
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FillColor = Color.FromArgb(204, 227, 222);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(55, 58, 64);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(24, 76);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(298, 35);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 18, 25);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(246, 255, 248);
            btnSearch.Location = new Point(344, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(107, 144, 128);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(246, 255, 248);
            btnAdd.Location = new Point(944, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 52);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add a guest";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlGuestList
            // 
            pnlGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGuestList.BackColor = Color.FromArgb(204, 227, 222);
            pnlGuestList.Controls.Add(dgvGuestList);
            pnlGuestList.Location = new Point(28, 161);
            pnlGuestList.Name = "pnlGuestList";
            pnlGuestList.Size = new Size(1067, 548);
            pnlGuestList.TabIndex = 6;
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AllowUserToDeleteRows = false;
            dgvGuestList.AllowUserToResizeColumns = false;
            dgvGuestList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvGuestList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGuestList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGuestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGuestList.ColumnHeadersHeight = 22;
            dgvGuestList.Columns.AddRange(new DataGridViewColumn[] { RoomID, RoomNum, LastName, FirstName, Contact, CheckIn, CheckOut, GuestStatus, CategoryName, guestIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, suffixDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, contactDataGridViewTextBoxColumn, guestStatusDataGridViewTextBoxColumn, roomIDDataGridViewTextBoxColumn, roomNumDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn });
            dgvGuestList.DataSource = guestRoomCategoryDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGuestList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGuestList.GridColor = Color.FromArgb(231, 229, 255);
            dgvGuestList.Location = new Point(0, 3);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.ReadOnly = true;
            dgvGuestList.RowHeadersVisible = false;
            dgvGuestList.RowHeadersWidth = 51;
            dgvGuestList.RowTemplate.Height = 29;
            dgvGuestList.Size = new Size(1064, 545);
            dgvGuestList.TabIndex = 0;
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
            dgvGuestList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGuestList.ThemeStyle.HeaderStyle.Height = 22;
            dgvGuestList.ThemeStyle.ReadOnly = true;
            dgvGuestList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGuestList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuestList.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvGuestList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvGuestList.ThemeStyle.RowsStyle.Height = 29;
            dgvGuestList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGuestList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvGuestList.CellContentClick += dgvGuestList_CellContentClick;
            // 
            // RoomID
            // 
            RoomID.DataPropertyName = "RoomID";
            RoomID.HeaderText = "RoomID";
            RoomID.MinimumWidth = 6;
            RoomID.Name = "RoomID";
            RoomID.ReadOnly = true;
            // 
            // RoomNum
            // 
            RoomNum.DataPropertyName = "RoomNum";
            RoomNum.HeaderText = "RoomNum";
            RoomNum.MinimumWidth = 6;
            RoomNum.Name = "RoomNum";
            RoomNum.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // Contact
            // 
            Contact.DataPropertyName = "Contact";
            Contact.HeaderText = "Contact";
            Contact.MinimumWidth = 6;
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            // 
            // CheckIn
            // 
            CheckIn.DataPropertyName = "CheckIn";
            CheckIn.HeaderText = "CheckIn";
            CheckIn.MinimumWidth = 6;
            CheckIn.Name = "CheckIn";
            CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            CheckOut.DataPropertyName = "CheckOut";
            CheckOut.HeaderText = "CheckOut";
            CheckOut.MinimumWidth = 6;
            CheckOut.Name = "CheckOut";
            CheckOut.ReadOnly = true;
            // 
            // GuestStatus
            // 
            GuestStatus.DataPropertyName = "GuestStatus";
            GuestStatus.HeaderText = "GuestStatus";
            GuestStatus.MinimumWidth = 6;
            GuestStatus.Name = "GuestStatus";
            GuestStatus.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "CategoryName";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            suffixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestStatusDataGridViewTextBoxColumn
            // 
            guestStatusDataGridViewTextBoxColumn.DataPropertyName = "GuestStatus";
            guestStatusDataGridViewTextBoxColumn.HeaderText = "GuestStatus";
            guestStatusDataGridViewTextBoxColumn.Name = "guestStatusDataGridViewTextBoxColumn";
            guestStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            roomNumDataGridViewTextBoxColumn.HeaderText = "RoomNum";
            roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            roomNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // guestRoomCategoryDTOBindingSource
            // 
            guestRoomCategoryDTOBindingSource.DataSource = typeof(CLASSES.Joined_Tables.GuestRoomCategoryDTO);
            // 
            // guestModelBindingSource
            // 
            guestModelBindingSource.DataSource = typeof(CLASSES.GuestModel);
            // 
            // comboSearchStatus
            // 
            comboSearchStatus.BackColor = Color.FromArgb(204, 227, 222);
            comboSearchStatus.Items.AddRange(new object[] { "Check In", "Check Out", "All" });
            comboSearchStatus.Location = new Point(594, 83);
            comboSearchStatus.Name = "comboSearchStatus";
            comboSearchStatus.Size = new Size(151, 25);
            comboSearchStatus.TabIndex = 7;
            comboSearchStatus.SelectedIndexChanged += comboSearchStatus_SelectedIndexChanged;
            // 
            // DashboardGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(comboSearchStatus);
            Controls.Add(pnlGuestList);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardGuest";
            Text = "DashboardGuest";
            pnlGuestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Panel pnlGuestList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGuestList;
        private BindingSource guestModelBindingSource;
        private ComboBox comboSearchStatus;
        private BindingSource guestRoomCategoryDTOBindingSource;
        private DataGridViewTextBoxColumn RoomID;
        private DataGridViewTextBoxColumn RoomNum;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn CheckIn;
        private DataGridViewTextBoxColumn CheckOut;
        private DataGridViewTextBoxColumn GuestStatus;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
    }
}