﻿namespace NOAKAY.AUTH
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnEnter = new Button();
            CheckBoxPassword = new CheckBox();
            label2 = new Label();
            entryPassword = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            entryUsername = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            picExit = new PictureBox();
            picMinimize = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(138, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 532);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 255, 248);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnEnter);
            panel3.Controls.Add(CheckBoxPassword);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(entryPassword);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(entryUsername);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(416, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 532);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(202, 103, 2);
            label5.Location = new Point(134, 90);
            label5.Name = "label5";
            label5.Size = new Size(182, 19);
            label5.TabIndex = 9;
            label5.Text = "LOG YOUR ACCOUNT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(165, 434);
            label4.Name = "label4";
            label4.Size = new Size(113, 16);
            label4.TabIndex = 7;
            label4.Text = "Forgot Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = Color.FromArgb(202, 103, 2);
            label3.Location = new Point(90, 479);
            label3.Name = "label3";
            label3.Size = new Size(250, 20);
            label3.TabIndex = 6;
            label3.Text = "Need an account? Register Here";
            label3.Click += label3_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(53, 79, 82);
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.FromArgb(246, 255, 248);
            btnEnter.Location = new Point(125, 382);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(191, 40);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // CheckBoxPassword
            // 
            CheckBoxPassword.AutoSize = true;
            CheckBoxPassword.Location = new Point(222, 340);
            CheckBoxPassword.Name = "CheckBoxPassword";
            CheckBoxPassword.Size = new Size(145, 24);
            CheckBoxPassword.TabIndex = 4;
            CheckBoxPassword.Text = "Show Password";
            CheckBoxPassword.UseVisualStyleBackColor = true;
            CheckBoxPassword.CheckedChanged += CheckBoxPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 58, 64);
            label2.Location = new Point(69, 238);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // entryPassword
            // 
            entryPassword.BackColor = Color.FromArgb(204, 227, 222);
            entryPassword.CustomizableEdges = customizableEdges1;
            entryPassword.DefaultText = "";
            entryPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            entryPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            entryPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            entryPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            entryPassword.FillColor = Color.FromArgb(204, 227, 222);
            entryPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            entryPassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryPassword.ForeColor = Color.FromArgb(55, 58, 64);
            entryPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            entryPassword.Location = new Point(69, 273);
            entryPassword.Margin = new Padding(3, 4, 3, 4);
            entryPassword.Name = "entryPassword";
            entryPassword.PasswordChar = '\0';
            entryPassword.PlaceholderText = "";
            entryPassword.SelectedText = "";
            entryPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            entryPassword.Size = new Size(298, 46);
            entryPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 58, 64);
            label1.Location = new Point(69, 135);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
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
            entryUsername.Location = new Point(69, 170);
            entryUsername.Margin = new Padding(3, 4, 3, 4);
            entryUsername.Name = "entryUsername";
            entryUsername.PasswordChar = '\0';
            entryUsername.PlaceholderText = "";
            entryUsername.SelectedText = "";
            entryUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            entryUsername.Size = new Size(298, 46);
            entryUsername.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 79, 82);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 532);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(1102, 12);
            picExit.Name = "picExit";
            picExit.Size = new Size(27, 26);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 1;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // picMinimize
            // 
            picMinimize.Image = (Image)resources.GetObject("picMinimize.Image");
            picMinimize.Location = new Point(1069, 12);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(27, 26);
            picMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimize.TabIndex = 3;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 70);
            ClientSize = new Size(1141, 720);
            Controls.Add(picMinimize);
            Controls.Add(picExit);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1141, 720);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox entryUsername;
        private Panel panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox entryPassword;
        private CheckBox CheckBoxPassword;
        private Label label3;
        private Button btnEnter;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox picExit;
        private PictureBox picMinimize;
    }
}