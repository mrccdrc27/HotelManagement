namespace NOAKAY.DASHFORM
{
    partial class UpdateRoomStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRoomStat));
            label8 = new Label();
            comboRoomNo = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            comboRoomStat = new ComboBox();
            picExit = new PictureBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(55, 58, 64);
            label8.Location = new Point(28, 38);
            label8.Name = "label8";
            label8.Size = new Size(206, 23);
            label8.TabIndex = 19;
            label8.Text = "Update Room Status";
            // 
            // comboRoomNo
            // 
            comboRoomNo.BackColor = Color.FromArgb(204, 227, 222);
            comboRoomNo.FormattingEnabled = true;
            comboRoomNo.Items.AddRange(new object[] { "101 (Standard)", "102 (Standard)", "103 (Standard)", "104 (Standard)", "105 (Standard)", "106 (Deluxe)", "107 (Deluxe)", "108 (Deluxe)", "109 (Deluxe)", "110 (Deluxe)", "111 (Suite)", "112 (Suite)", "113 (Suite)", "114 (Suite)", "115 (Suite)" });
            comboRoomNo.Location = new Point(28, 120);
            comboRoomNo.Name = "comboRoomNo";
            comboRoomNo.Size = new Size(188, 28);
            comboRoomNo.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(55, 58, 64);
            label5.Location = new Point(28, 97);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 29;
            label5.Text = "Room No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(277, 97);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 31;
            label1.Text = "Room Status";
            // 
            // comboRoomStat
            // 
            comboRoomStat.BackColor = Color.FromArgb(204, 227, 222);
            comboRoomStat.FormattingEnabled = true;
            comboRoomStat.Items.AddRange(new object[] { "Occupied", "Available", "Unavailable" });
            comboRoomStat.Location = new Point(277, 120);
            comboRoomStat.Name = "comboRoomStat";
            comboRoomStat.Size = new Size(188, 28);
            comboRoomStat.TabIndex = 30;
            // 
            // picExit
            // 
            picExit.Anchor = AnchorStyles.Right;
            picExit.Cursor = Cursors.Hand;
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(602, 12);
            picExit.Name = "picExit";
            picExit.Size = new Size(27, 26);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 32;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(107, 144, 128);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(246, 255, 248);
            btnAdd.Location = new Point(28, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 52);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Done";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // UpdateRoomStat
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 349);
            Controls.Add(btnAdd);
            Controls.Add(picExit);
            Controls.Add(label1);
            Controls.Add(comboRoomStat);
            Controls.Add(label5);
            Controls.Add(comboRoomNo);
            Controls.Add(label8);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateRoomStat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRoomStat";
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Guna.UI2.WinForms.Guna2TextBox entryLastName;
        private ComboBox comboRoomNo;
        private Label label5;
        private Label label1;
        private ComboBox comboRoomStat;
        private PictureBox picExit;
        private Button btnAdd;
    }
}