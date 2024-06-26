using System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLCONNECTION;
using NOAKAY.CLASSES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NOAKAY.DASHFORM
{
    public partial class InsertBooking : Form
    {
        public Connection? dbContext;
        public InsertBooking()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbContext = new Connection();  // Connects to the database
            this.dbContext.Database.EnsureCreated(); // Creates the database

            string lastname = entryLastName.Text;
            string firstname = entryFirstName.Text;
            string middlename = entryMiddleName.Text;
            string suffix = entrySuffix.Text;
            string address = entryAddress.Text;
            string contact = entryContact.Text;
            string email = entryEmail.Text;
            int roomid = (int)comboRoomNType.SelectedIndex + 1;
            //  int roomid = comboRoomID.SelectedIndex +1;
            int bookingstatus = comboBookingStatus.SelectedIndex; // 0 or 1
            DateTime checkout = dtpCheckOut.Value;
            DateTime checkin = dtpCheckIn.Value;

            // Check if the room is already occupied
            bool isRoomOccupied = dbContext.GuestModels.Any(g => g.RoomID == roomid &&
                                                         g.CheckIn <= checkout && g.CheckOut >= checkin);

            if (isRoomOccupied)
            {
                MessageBox.Show("This room is already occupied for the selected dates. Please choose another room or adjust dates.");
                return; // Exit the method without adding the guest
            }

            // creating new row
            // Create a new Account object
            GuestModel newAccount = new GuestModel
            {
                LastName = lastname,
                FirstName = firstname,
                MiddleName = middlename,
                Suffix = suffix,
                Address = address,
                Contact = contact,
                Email = email,
                RoomID = roomid,
                BookingStatus = bookingstatus,
                CheckIn = checkin,
                CheckOut = checkout

            };

            // Add the new Account object to the DbSet
            dbContext?.GuestModels.Add(newAccount);

            // Save changes to the database
            dbContext?.SaveChanges();

            MessageBox.Show("Booking Recorded!");
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
