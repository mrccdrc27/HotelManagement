namespace NOAKAY.DASHFORM
{
    partial class ReservedString1
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
            label8 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(55, 58, 64);
            label8.Location = new Point(442, 322);
            label8.Name = "label8";
            label8.Size = new Size(193, 23);
            label8.TabIndex = 47;
            label8.Text = "RESERVED STRING 1";
            label8.Click += label8_Click;
            // 
            // ReservedString1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1119, 738);
            Controls.Add(label8);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservedString1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservedString1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
    }
}