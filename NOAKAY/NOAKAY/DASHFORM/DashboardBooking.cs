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
using NOAKAY.CLASSES.Joined_Tables;
using SQLCONNECTION;

namespace NOAKAY.DASHFORM
{

    public partial class DashboardBooking : Form
    {
        private Connection dbContext;
        private List<Invoice> allGuests; // To store the original list of guests
        public DashboardBooking()
        {
            InitializeComponent();
            //Loadinvoce();
            LoadBooking();

        }


        public void LoadBooking()
        {
            this.dbContext = new Connection();
            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               //Initial Join of Guest and Room
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new Invoice
                               {
                                   fullName = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
                                   guestID = Guest.GuestID,
                                   checkIn = Guest.CheckIn,
                                   checkOut = Guest.CheckOut,
                                   status =$"{Guest.BookingStatus}",
                                   price = ((Guest.CheckOut.Value).Day - (Guest.CheckIn.Value).Day) * Category.basePrice,
                                   roomName = Room.RoomNum,
                               };

            var combinedList = combinedData.ToList();
            allGuests = combinedList;

            foreach (var item in combinedList)
            {

                if (item.status == "0")
                {
                    // Change GuestStatus if it is 1
                    item.status = "Pending"; // Example change to 3
                }
                else if (item.status == "1")
                {
                    // Change GuestStatus if it is 2
                    item.status = "Paid"; // Example change to 3
                }
                else if (item.status == "2")
                {
                    // Change GuestStatus if it is 2
                    item.status = "Cancel"; // Example change to 3
                }
                // Add more conditions as needed

            }


            this.dbContext.Database.CloseConnection();

           invoiceBindingSource.DataSource = combinedList;

        } // LoadBooking

        public void Loadinvoce()
        {

            this.dbContext = new Connection();

            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               //Initial Join of Guest and Room
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new Invoice
                               {
                                   fullName = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
                                   guestID = Guest.GuestID,
                                   checkIn = Guest.CheckIn,
                                   checkOut = Guest.CheckOut,
                                   price = ((Guest.CheckOut.Value).Day - (Guest.CheckIn.Value).Day) * Category.basePrice,
                                   roomName = Room.RoomNum,
                               };
            var combinedList = combinedData.ToList();

            //dgvInvoiceList.DataSource = combinedList;
            invoiceBindingSource.DataSource = combinedList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new InsertBooking().Show();
        }
    }




}
