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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btnSearch = new Button();
            entryUsername = new Guna.UI2.WinForms.Guna2TextBox();
            pnlGuestList = new Panel();
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
            entryUsername.CustomizableEdges = customizableEdges9;
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
            entryUsername.ShadowDecoration.CustomizableEdges = customizableEdges10;
            entryUsername.Size = new Size(298, 35);
            entryUsername.TabIndex = 5;
            // 
            // pnlGuestList
            // 
            pnlGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGuestList.BackColor = Color.FromArgb(204, 227, 222);
            pnlGuestList.Location = new Point(28, 161);
            pnlGuestList.Name = "pnlGuestList";
            pnlGuestList.Size = new Size(1067, 548);
            pnlGuestList.TabIndex = 7;
            // 
            // DashboardBooking
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox entryUsername;
        private Panel pnlGuestList;
    }
}