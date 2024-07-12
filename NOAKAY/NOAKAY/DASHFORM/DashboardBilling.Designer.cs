namespace NOAKAY.DASHFORM
{
    partial class DashboardBilling
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
            label8 = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            btnSearch = new Button();
            panel1 = new Panel();
            dgvGuestList = new Guna.UI2.WinForms.Guna2DataGridView();
            guestRoomCategoryDTOBindingSource = new BindingSource(components);
            btnPrintInvoice = new Button();
            btnBilling = new Button();
            GuestID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            RoomNum = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            GuestStatus = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(55, 58, 64);
            label8.Location = new Point(21, 24);
            label8.Name = "label8";
            label8.Size = new Size(190, 23);
            label8.TabIndex = 47;
            label8.Text = "Billing and Invoice";
            label8.Click += label8_Click;
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
            txtSearch.Location = new Point(21, 71);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(298, 35);
            txtSearch.TabIndex = 48;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 18, 25);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(246, 255, 248);
            btnSearch.Location = new Point(350, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 50;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(dgvGuestList);
            panel1.Location = new Point(21, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 122);
            panel1.TabIndex = 51;
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AllowUserToDeleteRows = false;
            dgvGuestList.AllowUserToResizeColumns = false;
            dgvGuestList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvGuestList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuestList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGuestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGuestList.ColumnHeadersHeight = 40;
            dgvGuestList.Columns.AddRange(new DataGridViewColumn[] { GuestID, FirstName, LastName, RoomNum, CategoryName, GuestStatus, CheckIn, CheckOut, Payment });
            dgvGuestList.DataSource = guestRoomCategoryDTOBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGuestList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGuestList.Dock = DockStyle.Fill;
            dgvGuestList.GridColor = Color.FromArgb(231, 229, 255);
            dgvGuestList.Location = new Point(0, 0);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.ReadOnly = true;
            dgvGuestList.RowHeadersVisible = false;
            dgvGuestList.RowHeadersWidth = 51;
            dgvGuestList.Size = new Size(1071, 122);
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
            dgvGuestList.ThemeStyle.HeaderStyle.Height = 40;
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
            // guestRoomCategoryDTOBindingSource
            // 
            guestRoomCategoryDTOBindingSource.DataSource = typeof(CLASSES.Joined_Tables.GuestRoomCategoryDTO);
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintInvoice.BackColor = Color.FromArgb(107, 144, 128);
            btnPrintInvoice.FlatAppearance.BorderSize = 0;
            btnPrintInvoice.FlatStyle = FlatStyle.Flat;
            btnPrintInvoice.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintInvoice.ForeColor = Color.FromArgb(246, 255, 248);
            btnPrintInvoice.Location = new Point(941, 287);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(151, 52);
            btnPrintInvoice.TabIndex = 52;
            btnPrintInvoice.Text = "Print Invoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.ForestGreen;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.FromArgb(246, 255, 248);
            btnBilling.Location = new Point(21, 287);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(151, 52);
            btnBilling.TabIndex = 53;
            btnBilling.Text = "Proceed to Billing";
            btnBilling.UseVisualStyleBackColor = false;
            // 
            // GuestID
            // 
            GuestID.DataPropertyName = "GuestID";
            GuestID.HeaderText = "GuestID";
            GuestID.MinimumWidth = 6;
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
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
            // GuestStatus
            // 
            GuestStatus.DataPropertyName = "GuestStatus";
            GuestStatus.HeaderText = "GuestStatus";
            GuestStatus.MinimumWidth = 6;
            GuestStatus.Name = "GuestStatus";
            GuestStatus.ReadOnly = true;
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
            // Payment
            // 
            Payment.FlatStyle = FlatStyle.Flat;
            Payment.HeaderText = "Payment";
            Payment.MinimumWidth = 6;
            Payment.Name = "Payment";
            Payment.ReadOnly = true;
            Payment.Text = "Payment";
            Payment.ToolTipText = "Payment";
            Payment.UseColumnTextForButtonValue = true;
            // 
            // DashboardBilling
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(btnBilling);
            Controls.Add(btnPrintInvoice);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardBilling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservedString1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestRoomCategoryDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Button btnSearch;
        private Panel panel1;
        private Button btnPrintInvoice;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGuestList;
        private Button btnBilling;
        private BindingSource guestRoomCategoryDTOBindingSource;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn RoomNum;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn GuestStatus;
        private DataGridViewTextBoxColumn CheckIn;
        private DataGridViewTextBoxColumn CheckOut;
        private DataGridViewButtonColumn Payment;
    }
}