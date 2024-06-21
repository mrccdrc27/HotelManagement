namespace UIHMS
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            splitter1 = new Splitter();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel9 = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            panel5 = new Panel();
            reservationForm1 = new ReservationForm();
            guestTableBindingSource = new BindingSource(components);
            room1 = new Room();
            menu11 = new GuestForm();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(splitter1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 49);
            panel1.TabIndex = 0;
            panel1.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(273, 19);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(459, 28);
            label4.TabIndex = 0;
            label4.Text = "NOAKAY HOTEL MANAGEMENT SYSTEM";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(273, 47);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 215, 215);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 28);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(215, 215, 215);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(96, 604);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(96, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 604);
            panel4.TabIndex = 3;
            panel4.Click += panel7_Paint;
            panel4.Paint += panel4_Paint;
            panel4.DoubleClick += panel7_Paint;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(pictureBox1);
            panel7.Location = new Point(0, 148);
            panel7.Name = "panel7";
            panel7.Size = new Size(176, 53);
            panel7.TabIndex = 4;
            panel7.Click += panel7_Paint;
            panel7.DoubleClick += panel7_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Century Gothic", 11F);
            label3.Location = new Point(41, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 15, 0, 0);
            label3.Size = new Size(122, 35);
            label3.TabIndex = 2;
            label3.Text = "Reservations";
            label3.Click += panel7_Paint;
            label3.DoubleClick += panel7_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += panel7_Paint;
            pictureBox1.DoubleClick += panel7_Paint;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label2);
            panel9.Controls.Add(pictureBox3);
            panel9.Location = new Point(0, 95);
            panel9.Name = "panel9";
            panel9.Size = new Size(176, 53);
            panel9.TabIndex = 3;
            panel9.Click += panel7_Paint;
            panel9.DoubleClick += panel7_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Century Gothic", 11F);
            label2.Location = new Point(41, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 15, 0, 0);
            label2.Size = new Size(77, 35);
            label2.TabIndex = 2;
            label2.Text = "Rooms";
            label2.Click += panel7_Paint;
            label2.DoubleClick += panel7_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += panel7_Paint;
            pictureBox3.DoubleClick += panel7_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(242, 242, 242);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label1);
            panel8.Controls.Add(pictureBox2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 42);
            panel8.Name = "panel8";
            panel8.Size = new Size(176, 53);
            panel8.TabIndex = 2;
            panel8.Click += panel7_Paint;
            panel8.Paint += panel8_Paint;
            panel8.DoubleClick += panel7_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Century Gothic", 11F);
            label1.Location = new Point(41, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 15, 0, 0);
            label1.Size = new Size(78, 35);
            label1.TabIndex = 3;
            label1.Text = "Guests";
            label1.Click += panel7_Paint;
            label1.DoubleClick += panel7_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += panel7_Paint;
            pictureBox2.DoubleClick += panel7_Paint;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 42);
            panel6.TabIndex = 0;
            panel6.Paint += panel6_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(215, 215, 215);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(968, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(96, 604);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // reservationForm1
            // 
            reservationForm1.BackColor = Color.FromArgb(242, 242, 242);
            reservationForm1.BorderStyle = BorderStyle.FixedSingle;
            reservationForm1.Dock = DockStyle.Fill;
            reservationForm1.Location = new Point(274, 77);
            reservationForm1.Name = "reservationForm1";
            reservationForm1.Size = new Size(694, 604);
            reservationForm1.TabIndex = 7;
            reservationForm1.Load += reservationForm1_Load;
            // 
            // guestTableBindingSource
            // 
            guestTableBindingSource.DataSource = typeof(Guest_Table);
            // 
            // room1
            // 
            room1.BackColor = Color.FromArgb(242, 242, 242);
            room1.Location = new Point(274, 77);
            room1.Name = "room1";
            room1.Size = new Size(694, 626);
            room1.TabIndex = 8;
            // 
            // menu11
            // 
            menu11.BackColor = Color.FromArgb(242, 242, 242);
            menu11.Location = new Point(274, 77);
            menu11.Name = "menu11";
            menu11.Size = new Size(694, 626);
            menu11.TabIndex = 9;
            menu11.Load += guestForm1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(menu11);
            Controls.Add(room1);
            Controls.Add(reservationForm1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestTableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Label label3;
        private PictureBox pictureBox1;
        private ReservationForm reservationForm1;
        private Label label4;
        private Splitter splitter1;
        private BindingSource guestTableBindingSource;
        private Room room1;
        private GuestForm menu11;
    }
}