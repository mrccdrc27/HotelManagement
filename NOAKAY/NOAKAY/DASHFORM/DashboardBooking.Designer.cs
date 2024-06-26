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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            btnSearch = new Button();
            entryUsername = new Guna.UI2.WinForms.Guna2TextBox();
            pnlGuestList = new Panel();
            dgvInvoiceList = new Guna.UI2.WinForms.Guna2DataGridView();
            guestIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoiceBindingSource = new BindingSource(components);
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
            label1.Size = new Size(97, 19);
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
            entryUsername.CustomizableEdges = customizableEdges3;
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
            entryUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvInvoiceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvInvoiceList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoiceList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInvoiceList.ColumnHeadersHeight = 22;
            dgvInvoiceList.Columns.AddRange(new DataGridViewColumn[] { guestIDDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, roomNameDataGridViewTextBoxColumn, checkInDataGridViewTextBoxColumn, checkOutDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dgvInvoiceList.DataSource = invoiceBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvInvoiceList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvInvoiceList.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoiceList.Location = new Point(1, 2);
            dgvInvoiceList.Name = "dgvInvoiceList";
            dgvInvoiceList.ReadOnly = true;
            dgvInvoiceList.RowHeadersVisible = false;
            dgvInvoiceList.RowHeadersWidth = 51;
            dgvInvoiceList.RowTemplate.Height = 29;
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
            // guestIDDataGridViewTextBoxColumn
            // 
            guestIDDataGridViewTextBoxColumn.DataPropertyName = "guestID";
            guestIDDataGridViewTextBoxColumn.HeaderText = "guestID";
            guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            roomNameDataGridViewTextBoxColumn.HeaderText = "roomName";
            roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            checkInDataGridViewTextBoxColumn.DataPropertyName = "checkIn";
            checkInDataGridViewTextBoxColumn.HeaderText = "checkIn";
            checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            checkInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            checkOutDataGridViewTextBoxColumn.DataPropertyName = "checkOut";
            checkOutDataGridViewTextBoxColumn.HeaderText = "checkOut";
            checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            checkOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceBindingSource
            // 
            invoiceBindingSource.DataSource = typeof(CLASSES.Joined_Tables.Invoice);
            // 
            // DashboardBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
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
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource invoiceBindingSource;
    }
}