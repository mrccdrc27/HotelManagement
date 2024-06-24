using NOAKAY.AUTH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardMain : Form
    {
        public DashboardMain()
        {
            InitializeComponent();
            loadform(new DashboardRoom());
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isMaximized = false; // Flag to track the state
        private void picMaximize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                // Maximize the form
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true; // Update the flag
            }
            else
            {
                // Restore original size
                this.WindowState = FormWindowState.Normal;
                isMaximized = false; // Update the flag
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        public void loadform(object Form)
        {
            if (pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            this.pnlContent.Tag = f;
            f.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnRoom.BackColor = Color.FromArgb(82, 121, 111);
            loadform(new DashboardRoom());
            
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnGuest.BackColor = Color.FromArgb(82, 121, 111);
            loadform(new DashboardGuest());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnBook.BackColor = Color.FromArgb(82, 121, 111);
            loadform(new DashboardBooking());
        }

        private void ResetButtonColors()
        {
            // Reset all buttons to default background color
            btnRoom.BackColor = Color.FromArgb(53, 79, 82);
            btnGuest.BackColor = Color.FromArgb(53, 79, 82);
            btnBook.BackColor = Color.FromArgb(53, 79, 82);
            // Add more buttons as needed
        }
    }
}
