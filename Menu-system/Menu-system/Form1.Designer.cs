namespace Menu_system
{
    partial class Form1
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
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            Menu4_Panel = new Panel();
            label5 = new Label();
            Menu3_Panel = new Panel();
            label4 = new Label();
            Menu2_Panel = new Panel();
            label3 = new Label();
            Menu1_Panel = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            Menu4_Panel.SuspendLayout();
            Menu3_Panel.SuspendLayout();
            Menu2_Panel.SuspendLayout();
            Menu1_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 50, 33);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 30);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(74, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 1;
            label1.Text = "NOAKAYHMS";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 247, 255);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Menu4_Panel);
            panel2.Controls.Add(Menu3_Panel);
            panel2.Controls.Add(Menu2_Panel);
            panel2.Controls.Add(Menu1_Panel);
            panel2.Location = new Point(27, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 550);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 208, 164);
            panel3.Location = new Point(196, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 550);
            panel3.TabIndex = 4;
            // 
            // Menu4_Panel
            // 
            Menu4_Panel.BackColor = SystemColors.ButtonFace;
            Menu4_Panel.BorderStyle = BorderStyle.FixedSingle;
            Menu4_Panel.Controls.Add(label5);
            Menu4_Panel.Location = new Point(0, 205);
            Menu4_Panel.Name = "Menu4_Panel";
            Menu4_Panel.Size = new Size(197, 47);
            Menu4_Panel.TabIndex = 3;
            Menu4_Panel.Click += label5_Click;
            Menu4_Panel.Paint += panel6_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 3;
            label5.Text = "MENU4";
            label5.Click += label5_Click;
            // 
            // Menu3_Panel
            // 
            Menu3_Panel.BackColor = SystemColors.ButtonFace;
            Menu3_Panel.BorderStyle = BorderStyle.FixedSingle;
            Menu3_Panel.Controls.Add(label4);
            Menu3_Panel.Location = new Point(0, 152);
            Menu3_Panel.Name = "Menu3_Panel";
            Menu3_Panel.Size = new Size(197, 47);
            Menu3_Panel.TabIndex = 2;
            Menu3_Panel.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 2;
            label4.Text = "MENU3";
            label4.Click += label4_Click;
            // 
            // Menu2_Panel
            // 
            Menu2_Panel.BackColor = SystemColors.ButtonFace;
            Menu2_Panel.BorderStyle = BorderStyle.FixedSingle;
            Menu2_Panel.Controls.Add(label3);
            Menu2_Panel.Location = new Point(0, 99);
            Menu2_Panel.Name = "Menu2_Panel";
            Menu2_Panel.Size = new Size(197, 47);
            Menu2_Panel.TabIndex = 1;
            Menu2_Panel.Click += label3_Click_1;
            Menu2_Panel.Paint += panel4_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "MENU2";
            label3.Click += label3_Click_1;
            // 
            // Menu1_Panel
            // 
            Menu1_Panel.BackColor = Color.FromArgb(242, 208, 164);
            Menu1_Panel.BorderStyle = BorderStyle.FixedSingle;
            Menu1_Panel.Controls.Add(label2);
            Menu1_Panel.Location = new Point(0, 40);
            Menu1_Panel.Name = "Menu1_Panel";
            Menu1_Panel.Size = new Size(197, 53);
            Menu1_Panel.TabIndex = 0;
            Menu1_Panel.Click += panel3_click;
            Menu1_Panel.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "MENU1";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 94, 117);
            ClientSize = new Size(1064, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            Menu4_Panel.ResumeLayout(false);
            Menu4_Panel.PerformLayout();
            Menu3_Panel.ResumeLayout(false);
            Menu3_Panel.PerformLayout();
            Menu2_Panel.ResumeLayout(false);
            Menu2_Panel.PerformLayout();
            Menu1_Panel.ResumeLayout(false);
            Menu1_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel Menu1_Panel;
        private Panel Menu4_Panel;
        private Panel Menu3_Panel;
        private Panel Menu2_Panel;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
    }
}