namespace HOTEL_LOGIN
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            checkboxShowPas = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtRegister = new Label();
            btnEnter = new Button();
            label4 = new Label();
            entryPassword = new TextBox();
            label2 = new Label();
            entryUsername = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(checkboxShowPas);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtRegister);
            panel1.Controls.Add(btnEnter);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(entryPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(entryUsername);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(729, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 720);
            panel1.TabIndex = 0;
            // 
            // checkboxShowPas
            // 
            checkboxShowPas.AutoSize = true;
            checkboxShowPas.Location = new Point(199, 462);
            checkboxShowPas.Name = "checkboxShowPas";
            checkboxShowPas.Size = new Size(132, 24);
            checkboxShowPas.TabIndex = 12;
            checkboxShowPas.Text = "Show Password";
            checkboxShowPas.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(313, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(370, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_interface;
            pictureBox1.Location = new Point(126, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtRegister
            // 
            txtRegister.AutoSize = true;
            txtRegister.Cursor = Cursors.Hand;
            txtRegister.ForeColor = Color.OrangeRed;
            txtRegister.Location = new Point(97, 605);
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(222, 20);
            txtRegister.TabIndex = 8;
            txtRegister.Text = "Need an account? Register Here";
            txtRegister.Click += txtRegister_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(104, 109, 118);
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Location = new Point(81, 518);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(250, 44);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(142, 576);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 6;
            label4.Text = "Forgot Password?";
            // 
            // entryPassword
            // 
            entryPassword.BorderStyle = BorderStyle.FixedSingle;
            entryPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryPassword.Location = new Point(81, 404);
            entryPassword.Multiline = true;
            entryPassword.Name = "entryPassword";
            entryPassword.PasswordChar = '*';
            entryPassword.Size = new Size(250, 43);
            entryPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 378);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // entryUsername
            // 
            entryUsername.BorderStyle = BorderStyle.FixedSingle;
            entryUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryUsername.Location = new Point(81, 296);
            entryUsername.Multiline = true;
            entryUsername.Name = "entryUsername";
            entryUsername.Size = new Size(250, 43);
            entryUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 270);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 95, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 679);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 41);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Symbol", 36F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label5.ForeColor = Color.FromArgb(220, 95, 0);
            label5.Location = new Point(191, 68);
            label5.Name = "label5";
            label5.Size = new Size(299, 74);
            label5.TabIndex = 1;
            label5.Text = "NOAKAY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(220, 142);
            label6.Name = "label6";
            label6.Size = new Size(234, 79);
            label6.TabIndex = 2;
            label6.Text = "HOTEL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 311);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 3;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 58, 64);
            ClientSize = new Size(1141, 720);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1141, 720);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOTEL MANAGEMENT SYSTEM";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox entryUsername;
        private Label label1;
        private Label label4;
        private TextBox entryPassword;
        private Label label2;
        private Button btnEnter;
        private Label txtRegister;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox checkboxShowPas;
    }
}
