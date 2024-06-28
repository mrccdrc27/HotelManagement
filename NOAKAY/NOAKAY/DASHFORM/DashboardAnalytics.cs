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
            int availableRooms = 0;
            int standardCount = 0;
            int deluxeCount = 0;
            int suiteCount = 0;

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
                    if (item.roomName > 100 && item.roomName < 106)
                    {
                        standardCount++;
                        activeGuestCount++;
                    }
                    else if (item.roomName > 105 && item.roomName < 111)
                    {
                        deluxeCount++;
                        activeGuestCount++;
                    }
                    else
                    {
                        suiteCount++;
                        activeGuestCount++;
                    }                 
                }
                if (item.status == "0")
                {
                    activeBookingCount++;

                }

                // Update labels with counts
                lblRoomNo.Text = "15"; // Example value, replace with actual room count logic
                lblGuestNo.Text = activeGuestCount.ToString();
                lblBookingNo.Text = activeBookingCount.ToString();
                lblOccupiedRooms.Text = activeGuestCount.ToString();
                availableRooms = 15 - activeGuestCount;
                lblAvailableRooms.Text = availableRooms.ToString();
                lblStandard.Text = standardCount.ToString();
                lblDeluxe.Text = deluxeCount.ToString();
                lblSuite.Text = suiteCount.ToString();
            } // loadData
        }
    }
}
