using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NOAKAY.CLASSES.Joined_Tables; // Adjust namespace as per your project
using SQLCONNECTION; // Adjust namespace as per your project

namespace NOAKAY.DASHFORM
{
    public partial class DashboardAnalytics : Form
    {
        private Connection dbContext;
        private List<Invoice> allGuests; // To store the original list of guests

        public DashboardAnalytics()
        {
            InitializeComponent();
           // dbContext = new Connection(); // Initialize your DbContext or connection
            loadData();
        }

        private void loadData()
        {
            int activeGuestCount = 0;
            int activeBookingCount = 0;

            this.dbContext = new Connection();
            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               //Initial Join of Guest and Room
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new Invoice // inner join
                               {
                                   fullName = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
                                   guestID = Guest.GuestID,
                                   checkIn = Guest.CheckIn,
                                   checkOut = Guest.CheckOut,
                                   gueststatus = $"{Guest.GuestStatus}",
                                   status = $"{Guest.BookingStatus}", // added
                                   roomName = Room.RoomNum,
                               };
            allGuests = combinedData.ToList();

            // Calculate counts
            foreach (var item in allGuests)
            {
                if (item.gueststatus == "0")
                {
                    activeGuestCount++;
                }
                if (item.status == "0")
                {
                    activeBookingCount++;
                }
            }

            // Update labels with counts
            lblRoomNo.Text = "15"; // Example value, replace with actual room count logic
            lblGuestNo.Text = activeGuestCount.ToString();
            lblBookingNo.Text = activeBookingCount.ToString();
        }
    }
}
