namespace WinFormsApp1
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
            AddGuest_Button = new Button();
            FirstName_Text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LastName_Text = new TextBox();
            label4 = new Label();
            MiddleName_Text = new TextBox();
            label5 = new Label();
            RoomID_Text = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // AddGuest_Button
            // 
            AddGuest_Button.Location = new Point(37, 321);
            AddGuest_Button.Name = "AddGuest_Button";
            AddGuest_Button.Size = new Size(75, 23);
            AddGuest_Button.TabIndex = 0;
            AddGuest_Button.Text = "Add";
            AddGuest_Button.UseVisualStyleBackColor = true;
            AddGuest_Button.Click += button1_Click;
            // 
            // FirstName_Text
            // 
            FirstName_Text.Location = new Point(129, 82);
            FirstName_Text.Name = "FirstName_Text";
            FirstName_Text.Size = new Size(228, 23);
            FirstName_Text.TabIndex = 1;
            FirstName_Text.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 85);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "FirstName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(37, 26);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 3;
            label2.Text = "Guest";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 155);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "LastName";
            label3.Click += label3_Click;
            // 
            // LastName_Text
            // 
            LastName_Text.Location = new Point(129, 152);
            LastName_Text.Name = "LastName_Text";
            LastName_Text.Size = new Size(228, 23);
            LastName_Text.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 122);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 6;
            label4.Text = "MiddleName";
            label4.Click += label4_Click;
            // 
            // MiddleName_Text
            // 
            MiddleName_Text.Location = new Point(129, 119);
            MiddleName_Text.Name = "MiddleName_Text";
            MiddleName_Text.Size = new Size(228, 23);
            MiddleName_Text.TabIndex = 7;
            MiddleName_Text.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 255);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "RoomNo";
            label5.Click += label5_Click;
            // 
            // RoomID_Text
            // 
            RoomID_Text.Location = new Point(129, 252);
            RoomID_Text.Name = "RoomID_Text";
            RoomID_Text.Size = new Size(228, 23);
            RoomID_Text.TabIndex = 9;
            RoomID_Text.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(37, 212);
            label6.Name = "label6";
            label6.Size = new Size(126, 28);
            label6.TabIndex = 10;
            label6.Text = "Assign Room";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(RoomID_Text);
            Controls.Add(label5);
            Controls.Add(MiddleName_Text);
            Controls.Add(label4);
            Controls.Add(LastName_Text);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FirstName_Text);
            Controls.Add(AddGuest_Button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddGuest_Button;
        private TextBox FirstName_Text;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LastName_Text;
        private Label label4;
        private TextBox MiddleName_Text;
        private Label label5;
        private TextBox RoomID_Text;
        private Label label6;
    }
}
