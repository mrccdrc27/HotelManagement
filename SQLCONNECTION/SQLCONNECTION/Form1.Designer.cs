using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace SQLCONNECTION
{
    partial class Form1
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
            create = new Button();
            Username_Input = new TextBox();
            Password_Input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // create
            // 
            create.Location = new Point(272, 243);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 0;
            create.Text = "Add";
            create.UseVisualStyleBackColor = true;
            create.Click += button1_Click;
            // 
            // Username_Input
            // 
            Username_Input.Location = new Point(272, 150);
            Username_Input.Name = "Username_Input";
            Username_Input.Size = new Size(288, 23);
            Username_Input.TabIndex = 1;
            // 
            // Password_Input
            // 
            Password_Input.Location = new Point(272, 196);
            Password_Input.Name = "Password_Input";
            Password_Input.Size = new Size(288, 23);
            Password_Input.TabIndex = 2;
            Password_Input.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 132);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 178);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(272, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Clearall";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 95);
            label3.Name = "label3";
            label3.Size = new Size(178, 15);
            label3.TabIndex = 6;
            label3.Text = "Database at bin inside this folder";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password_Input);
            Controls.Add(Username_Input);
            Controls.Add(create);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create;
        private TextBox Username_Input;
        private TextBox Password_Input;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}
