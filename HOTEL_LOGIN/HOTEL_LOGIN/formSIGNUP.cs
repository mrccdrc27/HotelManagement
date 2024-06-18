using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using SQLCONNECTION;
using System.Security.Principal;

namespace HOTEL_LOGIN
{
    public partial class formSIGNUP : Form
    {
        public Connection? dbContext;

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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            dbContext = new Connection();  //Connects to the database


            this.dbContext.Database.EnsureCreated(); //Creates the database

            //This Code will get username and password input from text forms
            string username = entryUsername.Text;
            string password = entryPassword.Text;
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
    } // formSIGNUP
}
