using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SQLCONNECTION
{
    public partial class Form1 : Form
    {
        public Connection? dbContext;


        public Form1()
        {
            InitializeComponent();
        }

        //On button click database is created

        private void button1_Click(object sender, EventArgs e)
        {
            dbContext = new Connection();  //Connects to the database


            this.dbContext.Database.EnsureCreated(); //Creates the database

            //This Code will get username and password input from text forms
            string username = Username_Input.Text;
            string password = Password_Input.Text;

            // Create a new Account object
            Account newAccount = new Account
            {
                Username = username,
                Password = password
            };

            // Add the new Account object to the DbSet
            dbContext?.Accounts.Add(newAccount);


            // Save changes to the database
            dbContext?.SaveChanges();

            MessageBox.Show("New account added to the database.");

            /*
            dbContext = new Connection();
            this.dbContext.Database.EnsureCreated();
            MessageBox.Show("database is created");

            //This Line will add whatever data is on Inputs
            this.dbContext.Accounts.Load();
            */
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dbContext = new Connection();  //Connects to the database
            dbContext?.Accounts.ExecuteDelete(); // Delete Table
            MessageBox.Show("All Accounts has been deleted.");

            //this.dbContext.Database.EnsureDeleted(); //Deletes the database
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
