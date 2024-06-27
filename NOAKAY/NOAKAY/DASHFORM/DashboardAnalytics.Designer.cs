namespace NOAKAY.DASHFORM
{
    partial class DashboardAnalytics
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
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            lblRoomNo = new Label();
            panel4 = new Panel();
            lblGuestNo = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lblBookingNo = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 79, 82);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 47);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(1119, 691);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel6, 3, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(25, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1069, 142);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(lblRoomNo);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0, 0, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 132);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "No. of Rooms";
            // 
            // lblRoomNo
            // 
            lblRoomNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRoomNo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNo.ForeColor = SystemColors.ControlLightLight;
            lblRoomNo.Location = new Point(3, 80);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(236, 34);
            lblRoomNo.TabIndex = 1;
            lblRoomNo.Text = "0000";
            lblRoomNo.TextAlign = ContentAlignment.MiddleRight;
         //   lblRoomNo.Click += lblRoomNo_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(lblGuestNo);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(267, 0);
            panel4.Margin = new Padding(0, 0, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 132);
            panel4.TabIndex = 1;
            // 
            // lblGuestNo
            // 
            lblGuestNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGuestNo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestNo.ForeColor = SystemColors.ControlLightLight;
            lblGuestNo.Location = new Point(3, 80);
            lblGuestNo.Name = "lblGuestNo";
            lblGuestNo.Size = new Size(236, 34);
            lblGuestNo.TabIndex = 1;
            lblGuestNo.Text = "0000";
            lblGuestNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 22);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 1;
            label4.Text = "Active Guest";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateBlue;
            panel5.Controls.Add(lblBookingNo);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(534, 0);
            panel5.Margin = new Padding(0, 0, 10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(257, 132);
            panel5.TabIndex = 2;
            // 
            // lblBookingNo
            // 
            lblBookingNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBookingNo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingNo.ForeColor = SystemColors.ControlLightLight;
            lblBookingNo.Location = new Point(3, 80);
            lblBookingNo.Name = "lblBookingNo";
            lblBookingNo.Size = new Size(236, 34);
            lblBookingNo.TabIndex = 1;
            lblBookingNo.Text = "0000";
            lblBookingNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(15, 22);
            label6.Name = "label6";
            label6.Size = new Size(168, 23);
            label6.TabIndex = 1;
            label6.Text = "Active Bookings";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Orange;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(801, 0);
            panel6.Margin = new Padding(0, 0, 10, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(258, 132);
            panel6.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(3, 80);
            label7.Name = "label7";
            label7.Size = new Size(236, 34);
            label7.TabIndex = 1;
            label7.Text = "0000";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(15, 22);
            label8.Name = "label8";
            label8.Size = new Size(158, 23);
            label8.TabIndex = 1;
            label8.Text = "Reserved String";
            // 
            // DashboardAnalytics
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 248);
            ClientSize = new Size(1119, 738);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardAnalytics";
            Text = "DashboardAnalytics";
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label lblRoomNo;
        private Label label1;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label lblBookingNo;
        private Label label6;
        private Panel panel4;
        private Label lblGuestNo;
        private Label label4;
    }
}