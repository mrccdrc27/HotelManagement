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
    public partial class UpdateGuestInfo : Form
    {
        public Connection? dbContext;
        public UpdateGuestInfo()
        {
            InitializeComponent();
        }

        private int guestID;
        public void LoadGuestInfo(int guestID, string lastName, string firstName, string middleName,
                                  string suffix, string address, string contact, string email,
                                  int guestStatus, DateTime checkIn, DateTime checkOut, int roomID)
        {
            entryLastName.Text = lastName;
            entryFirstName.Text = firstName;
            entryMiddleName.Text = middleName;
            entrySuffix.Text = suffix;
            entryAddress.Text = address;
            entryContact.Text = contact;
            entryEmail.Text = email;
            comboGuestStatus.SelectedIndex = guestStatus;
            dtpCheckIn.Value = checkIn;
            dtpCheckOut.Value = checkOut;
            comboRoomNType.SelectedIndex = roomID - 1;
            this.guestID = guestID;


        } // LoadGuestInfo

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            int gueststatus = comboGuestStatus.SelectedIndex; // 0 or 1
            DateTime checkout = dtpCheckOut.Value;
            DateTime checkin = dtpCheckIn.Value;

            var guestToUpdate = dbContext.GuestModels.SingleOrDefault(g => g.GuestID == guestID);


            if (guestToUpdate != null)
            {

                // Check if the room is already occupied
                bool isRoomOccupied = dbContext.GuestModels.Any(g => g.RoomID == roomid && g.GuestID != guestID && g.GuestStatus == 0);
              //  bool isRoomOccupied = dbContext.GuestModels.Any(g => g.RoomID == roomid && g.GuestID != guestID && g.GuestStatus == 0);

                if (isRoomOccupied)
                {
                    MessageBox.Show("This room is already occupied. Please choose another room.");
                    return; // Exit the method without adding the guest
                }

                // Update the guest's properties
                guestToUpdate.LastName = lastname;
                guestToUpdate.FirstName = firstname;
                guestToUpdate.MiddleName = middlename;
                guestToUpdate.Suffix = suffix;
                guestToUpdate.Address = address;
                guestToUpdate.Contact = contact;
                guestToUpdate.Email = email;
                guestToUpdate.RoomID = roomid;
                guestToUpdate.GuestStatus = gueststatus;
                guestToUpdate.CheckIn = checkin;
                guestToUpdate.CheckOut = checkout;

                // Save changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Guest information updated successfully!");
            }
            else
            {
                MessageBox.Show("Error: Guest not found.");
            }

            this.Close();
        }
    }
}
