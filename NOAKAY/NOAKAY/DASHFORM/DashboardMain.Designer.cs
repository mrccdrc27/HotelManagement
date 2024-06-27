namespace NOAKAY.DASHFORM
{
    partial class DashboardMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMain));
            pnlNav = new Panel();
            btnDashBoard = new Button();
            btnBook = new Button();
            btnReport = new Button();
            btnHouseKeeping = new Button();
            btnOut = new Button();
            btnGuest = new Button();
            btnRoom = new Button();
            pnlProfile = new Panel();
            pnlAppBar = new Panel();
            pictureBox1 = new PictureBox();
            picMinimize = new PictureBox();
            picMaximize = new PictureBox();
            picExit = new PictureBox();
            pnlContent = new Panel();
            pnlNav.SuspendLayout();
            pnlAppBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(53, 79, 82);
            pnlNav.Controls.Add(btnDashBoard);
            pnlNav.Controls.Add(btnBook);
            pnlNav.Controls.Add(btnReport);
            pnlNav.Controls.Add(btnHouseKeeping);
            pnlNav.Controls.Add(btnOut);
            pnlNav.Controls.Add(btnGuest);
            pnlNav.Controls.Add(btnRoom);
            pnlNav.Controls.Add(pnlProfile);
            pnlNav.Dock = DockStyle.Left;
            pnlNav.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlNav.Location = new Point(0, 47);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(250, 664);
            pnlNav.TabIndex = 0;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Cursor = Cursors.Hand;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.ForeColor = Color.FromArgb(246, 255, 248);
            btnDashBoard.Location = new Point(0, 131);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(247, 61);
            btnDashBoard.TabIndex = 7;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnBook
            // 
            btnBook.Cursor = Cursors.Hand;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.ForeColor = Color.FromArgb(246, 255, 248);
            btnBook.Location = new Point(3, 265);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(247, 61);
            btnBook.TabIndex = 3;
            btnBook.Text = "Booking List";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnReport
            // 
            btnReport.Cursor = Cursors.Hand;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = Color.FromArgb(246, 255, 248);
            btnReport.Location = new Point(0, 470);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(247, 61);
            btnReport.TabIndex = 6;
            btnReport.Text = "Reports";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnHouseKeeping
            // 
            btnHouseKeeping.Cursor = Cursors.Hand;
            btnHouseKeeping.FlatAppearance.BorderSize = 0;
            btnHouseKeeping.FlatStyle = FlatStyle.Flat;
            btnHouseKeeping.ForeColor = Color.FromArgb(246, 255, 248);
            btnHouseKeeping.Location = new Point(3, 403);
            btnHouseKeeping.Name = "btnHouseKeeping";
            btnHouseKeeping.Size = new Size(247, 61);
            btnHouseKeeping.TabIndex = 5;
            btnHouseKeeping.Text = "House Keeping";
            btnHouseKeeping.UseVisualStyleBackColor = true;
            btnHouseKeeping.Click += btnHouseKeeping_Click;
            // 
            // btnOut
            // 
            btnOut.BackColor = Color.FromArgb(202, 103, 2);
            btnOut.Cursor = Cursors.Hand;
            btnOut.Dock = DockStyle.Bottom;
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.FlatStyle = FlatStyle.Flat;
            btnOut.ForeColor = Color.FromArgb(246, 255, 248);
            btnOut.Location = new Point(0, 603);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(250, 61);
            btnOut.TabIndex = 4;
            btnOut.Text = "Log out";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // btnGuest
            // 
            btnGuest.Cursor = Cursors.Hand;
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.ForeColor = Color.FromArgb(246, 255, 248);
            btnGuest.Location = new Point(0, 332);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(247, 61);
            btnGuest.TabIndex = 2;
            btnGuest.Text = "Guest List";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnRoom
            // 
            btnRoom.BackgroundImageLayout = ImageLayout.Zoom;
            btnRoom.Cursor = Cursors.Hand;
            btnRoom.FlatAppearance.BorderSize = 0;
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.ForeColor = Color.FromArgb(246, 255, 248);
            btnRoom.Location = new Point(0, 198);
            btnRoom.Name = "btnRoom";
            btnRoom.RightToLeft = RightToLeft.No;
            btnRoom.Size = new Size(247, 61);
            btnRoom.TabIndex = 1;
            btnRoom.Text = "Room Available";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.FromArgb(47, 62, 70);
            pnlProfile.Dock = DockStyle.Top;
            pnlProfile.Location = new Point(0, 0);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(250, 125);
            pnlProfile.TabIndex = 0;
            // 
            // pnlAppBar
            // 
            pnlAppBar.BackColor = Color.FromArgb(47, 62, 70);
            pnlAppBar.Controls.Add(pictureBox1);
            pnlAppBar.Controls.Add(picMinimize);
            pnlAppBar.Controls.Add(picMaximize);
            pnlAppBar.Controls.Add(picExit);
            pnlAppBar.Dock = DockStyle.Top;
            pnlAppBar.Location = new Point(0, 0);
            pnlAppBar.Name = "pnlAppBar";
            pnlAppBar.Size = new Size(1369, 47);
            pnlAppBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // picMinimize
            // 
            picMinimize.Anchor = AnchorStyles.Right;
            picMinimize.Cursor = Cursors.Hand;
            picMinimize.Image = (Image)resources.GetObject("picMinimize.Image");
            picMinimize.Location = new Point(1264, 12);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(27, 26);
            picMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimize.TabIndex = 9;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            // 
            // picMaximize
            // 
            picMaximize.Anchor = AnchorStyles.Right;
            picMaximize.Cursor = Cursors.Hand;
            picMaximize.Image = (Image)resources.GetObject("picMaximize.Image");
            picMaximize.Location = new Point(1297, 12);
            picMaximize.Name = "picMaximize";
            picMaximize.Size = new Size(27, 26);
            picMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            picMaximize.TabIndex = 8;
            picMaximize.TabStop = false;
            picMaximize.Click += picMaximize_Click;
            // 
            // picExit
            // 
            picExit.Anchor = AnchorStyles.Right;
            picExit.Cursor = Cursors.Hand;
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(1330, 12);
            picExit.Name = "picExit";
            picExit.Size = new Size(27, 26);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 7;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 47);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1119, 664);
            pnlContent.TabIndex = 2;
            // 
            // DashboardMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 711);
            Controls.Add(pnlContent);
            Controls.Add(pnlNav);
            Controls.Add(pnlAppBar);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardMain";
            pnlNav.ResumeLayout(false);
            pnlAppBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private Panel pnlAppBar;
        private Button btnRoom;
        private Panel pnlProfile;
        private Button btnOut;
        private Button btnBook;
        private Button btnGuest;
        private Panel pnlContent;
        private PictureBox picMinimize;
        private PictureBox picMaximize;
        private PictureBox picExit;
        private PictureBox pictureBox1;
        private Button btnReport;
        private Button btnHouseKeeping;
        private Button btnDashBoard;
    }
}