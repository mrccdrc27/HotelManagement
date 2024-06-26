namespace NOAKAY.DASHFORM
{
    partial class DashboardBooking
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
            btnSearch = new Button();
            entryUsername = new Guna.UI2.WinForms.Guna2TextBox();
            pnlGuestList = new Panel();
            dgvInvoiceList = new Guna.UI2.WinForms.Guna2DataGridView();
            invoiceBindingSource = new BindingSource(components);
            btnAdd = new Button();
            guestIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlGuestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 3;
            label1.Text = "Booking List";
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
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // entryUsername
            // 
            entryUsername.BackColor = Color.FromArgb(204, 227, 222);
            entryUsername.CustomizableEdges = customizableEdges1;
            entryUsername.DefaultText = "";
            entryUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            entryUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            entryUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            entryUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            entryUsername.FillColor = Color.FromArgb(204, 227, 222);
            entryUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            entryUsername.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryUsername.ForeColor = Color.FromArgb(55, 58, 64);
            entryUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            entryUsername.Location = new Point(24, 76);
            entryUsername.Margin = new Padding(3, 4, 3, 4);
            entryUsername.Name = "entryUsername";
            entryUsername.PasswordChar = '\0';
            entryUsername.PlaceholderText = "";
            entryUsername.SelectedText = "";
            entryUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            entryUsername.Size = new Size(298, 35);
            entryUsername.TabIndex = 5;
            // 
            // pnlGuestList
            // 
            pnlGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGuestList.BackColor = Color.FromArgb(204, 227, 222);
            pnlGuestList.Controls.Add(dgvInvoiceList);
            pnlGuestList.Location = new Point(28, 161);
            pnlGuestList.Name = "pnlGuestList";
            pnlGuestList.Size = new Size(1067, 548);
            pnlGuestList.TabIndex = 7;
            // 
            // dgvInvoiceList
            // 
            dgvInvoiceList.AllowUserToAddRows = false;
            dgvInvoiceList.AllowUserToDeleteRows = false;
            dgvInvoiceList.AllowUserToResizeColumns = false;
            dgvInvoiceList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvInvoiceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoiceList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoiceList.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoiceList.ColumnHeadersHeight = 22;
            dgvInvoiceList.Columns.AddRange(new DataGridViewColumn[] { guestIDDataGridViewTextBoxColumn, status, fullNameDataGridViewTextBoxColumn, roomNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dgvInvoiceList.DataSource = invoiceBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInvoiceList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInvoiceList.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoiceList.Location = new Point(1, 2);
            dgvInvoiceList.Name = "dgvInvoiceList";
            dgvInvoiceList.ReadOnly = true;
            dgvInvoiceList.RowHeadersVisible = false;
            dgvInvoiceList.RowHeadersWidth = 51;
            dgvInvoiceList.Size = new Size(1064, 545);
            dgvInvoiceList.TabIndex = 1;
            dgvInvoiceList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInvoiceList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInvoiceList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInvoiceList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInvoiceList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInvoiceList.ThemeStyle.BackColor = Color.White;
            dgvInvoiceList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoiceList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInvoiceList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoiceList.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvInvoiceList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInvoiceList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoiceList.ThemeStyle.HeaderStyle.Height = 22;
            dgvInvoiceList.ThemeStyle.ReadOnly = true;
            dgvInvoiceList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInvoiceList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoiceList.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvInvoiceList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInvoiceList.ThemeStyle.RowsStyle.Height = 29;
            dgvInvoiceList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInvoiceList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // invoiceBindingSource
            // 
            invoiceBindingSource.DataSource = typeof(CLASSES.Joined_Tables.Invoice);
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(107, 144, 128);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(246, 255, 248);
            btnAdd.Location = new Point(942, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 52);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add a Booking";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            guestIDDataGridViewTextBoxColumn.DataPropertyName = "guestID";
            guestIDDataGridViewTextBoxColumn.HeaderText = "guestID";
            guestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
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
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.DataPropertyName = "checkIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "checkIn";
            checkInDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            checkOutDataGridViewTextBoxColumn.DataPropertyName = "checkOut";
            checkOutDataGridViewTextBoxColumn.HeaderText = "checkOut";
            checkOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DashboardBooking
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(btnAdd);
            Controls.Add(pnlGuestList);
            Controls.Add(btnSearch);
            Controls.Add(entryUsername);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardBooking";
            Text = "DashboardBooking";
            pnlGuestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox entryUsername;
        private Panel pnlGuestList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInvoiceList;
        private BindingSource invoiceBindingSource;
        private Button btnAdd;
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}