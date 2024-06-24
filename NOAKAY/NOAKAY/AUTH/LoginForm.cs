using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOAKAY.DASHFORM;
using SQLCONNECTION;

namespace NOAKAY.AUTH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            entryPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new SignupForm().Show();
            this.Hide();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            entryPassword.UseSystemPasswordChar = true;


            if (CheckBoxPassword.Checked)
            {
                entryPassword.UseSystemPasswordChar = false;

            }
            else
            {
                entryPassword.UseSystemPasswordChar = true;

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = entryUsername.Text;
            string password = entryPassword.Text;

            try
            {
                using (var dbContext = new Connection())
                {
                    var account = dbContext.PersonModels
                        .FirstOrDefault(a => a.Username == username && a.Password == password);

                    if (account != null)
                    {
                        new DashboardMain().Show();
                        MessageBox.Show("Login successful!");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            } // try
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            } // catch
        }
    }
}
