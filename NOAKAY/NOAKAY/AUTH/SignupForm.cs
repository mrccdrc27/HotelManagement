using NOAKAY.CLASSES;
using SQLCONNECTION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NOAKAY.AUTH
{
    public partial class SignupForm : Form
    {
        public Connection? dbContext;
        public SignupForm()
        {
            InitializeComponent();
            entryPassword.UseSystemPasswordChar = true;
            entryConfirmPassword.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            dbContext = new Connection();  // Connects to the database


            this.dbContext.Database.EnsureCreated(); // Creates the database

            // This Code will get username and password input from text forms
            string username = entryUsername.Text;
            string password = entryPassword.Text;
            // string contact = entryContact.Text;
            string confirmpassword = entryConfirmPassword.Text;

            if (password != confirmpassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }


            // Create a new Account object
            PersonModel newAccount = new PersonModel
            {
                Username = username,
                Password = password
            };

            // Add the new Account object to the DbSet
            dbContext?.PersonModels.Add(newAccount);


            // Save changes to the database
            dbContext?.SaveChanges();

            MessageBox.Show("New account added to the database.");
        }

        
        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            entryPassword.UseSystemPasswordChar = true;
            entryConfirmPassword.UseSystemPasswordChar = true;

            if (CheckBoxPassword.Checked)
            {
                entryPassword.UseSystemPasswordChar = false;
                entryConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                entryPassword.UseSystemPasswordChar = true;
                entryConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void picExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
