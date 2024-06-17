using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_LOGIN
{
    public partial class formSIGNUP : Form
    {
        public formSIGNUP()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label3_Click_1(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.WindowState = FormWindowState.Normal; // Ensure the form is not minimized
            loginForm.Show();
            this.Hide();
        }
    }
}
