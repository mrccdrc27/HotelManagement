using HMS;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Connection? Connection;

        public Form1()
        {
            InitializeComponent();

        }

        //On application load/run, execute code
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //creates database

            Connection = new Connection();
            this.Connection.Database.EnsureCreated();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //parsing Room ID to be integer
            int RoomID;
            bool isParsed = int.TryParse(RoomID_Text.Text, out RoomID);

            //putting textfields to attributes fields
            string FirstName = FirstName_Text.Text;
            string LastName = LastName_Text.Text;
            string MiddleName = MiddleName_Text.Text;


            //Condition to verify if roomID is valid input
            if (isParsed)
            {
                Connection = new Connection();
                this.Connection.Database.EnsureCreated();


                //placing values to a table/class
                Guest newGuest = new Guest
                {
                    FirstName = FirstName,
                    MiddleName = MiddleName,
                    LastName = LastName,
                    RoomID = RoomID
                };

                //adding table/class to database
                Connection?.Guests.Add(newGuest);
                Connection?.SaveChanges();



                MessageBox.Show(
                    "successfully added in database:" +
                    "Room ID:     ".PadRight(15) + RoomID + "\n" +
                    "First Name:  ".PadRight(15) + FirstName + "\n" +
                    "Middle Name: ".PadRight(15) + MiddleName + "\n" +
                    "Last Name:   ".PadRight(15) + LastName);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
