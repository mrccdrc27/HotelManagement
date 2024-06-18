using System;
using System.Linq;
using System.Windows.Forms;
using SQLCONNECTION;

namespace HOTEL_LOGIN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            new formSIGNUP().Show();
            this.Hide();
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
                        MessageBox.Show("Login successful!");
            
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
        } // btn
    }
}
