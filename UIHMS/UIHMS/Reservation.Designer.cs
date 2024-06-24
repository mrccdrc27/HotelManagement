namespace UIHMS
{
    partial class ReservationForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            ReservationList = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            guestTableBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 626);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(659, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(35, 626);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(ReservationList);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(36, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 31);
            panel1.TabIndex = 4;
            // 
            // ReservationList
            // 
            ReservationList.AutoSize = true;
            ReservationList.Dock = DockStyle.Bottom;
            ReservationList.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationList.Location = new Point(0, 11);
            ReservationList.Name = "ReservationList";
            ReservationList.Size = new Size(96, 20);
            ReservationList.TabIndex = 0;
            ReservationList.Text = "Reservation";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(36, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 150);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(36, 222);
            panel6.Name = "panel6";
            panel6.Size = new Size(623, 404);
            panel6.TabIndex = 7;
            panel6.Paint += panel6_Paint;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(36, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(623, 41);
            panel5.TabIndex = 6;
            // 
            // guestTableBindingSource
            // 
            guestTableBindingSource.DataSource = typeof(Guest_Table);
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "ReservationForm";
            Size = new Size(694, 626);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestTableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Label ReservationList;
        private BindingSource guestTableBindingSource;
    }
}
