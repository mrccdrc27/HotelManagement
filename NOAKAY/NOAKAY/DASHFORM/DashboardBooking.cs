using System;
using System.Collections;
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
            //LoadBooking();
            // LoadData(); // filter only guest that has 0 or 1 status, 2 means they are in booking list

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // newcode();
            loadData(); // filter booking list

        }

        public void loadData()
        {
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
                                   price = CalculateTotalPrice(Guest.CheckIn, Guest.CheckOut, Category.basePrice), // 28 30 1000
                                   roomName = Room.RoomNum,
                               };

            var combinedList = combinedData.ToList();
            // allGuests = combinedList;
            List<Invoice> filter = new List<Invoice>();

            foreach (var item in combinedList)
            {
                if (item.gueststatus == "2" && item.status == "0")
                {
                    item.status = "Pending";
                    filter.Add(item);
                }
                else if (item.gueststatus == "2" && item.status == "1")
                {
                    item.status = "Paid";
                    filter.Add(item);
                }
                else if (item.gueststatus == "2" && item.status == "2")
                {
                    item.status = "Cancelled";
                    filter.Add(item);
                }
            }
         
            dgvInvoiceList.DataSource = filter;
            allGuests = filter;

        } // LoadData
        private static decimal CalculateTotalPrice(DateTime? checkIn, DateTime? checkOut, int basePrice)
        {
            if (checkIn.HasValue && checkOut.HasValue)
            {
                TimeSpan totalDuration = checkOut.Value.Date.AddDays(1) - checkIn.Value.Date; // Corrected calculation
                decimal totalDays = (decimal)totalDuration.TotalDays; // Use TotalDays to get fractional days

                //MessageBox.Show($"{totalDays * basePrice}");

                return totalDays * basePrice;
            }
            return 0; // Handle the case where either check-in or check-out date is null
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new InsertBooking().Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            // Filter the original list based on the search term
            var filteredGuests = allGuests.Where(g =>
                g.fullName.ToLower().Contains(searchTerm)

            ).ToList();

            // Update the BindingSource with the filtered list
            invoiceBindingSource.DataSource = filteredGuests;
            dgvInvoiceList.DataSource = invoiceBindingSource; // i add this to bind the data to dgv

            // Refresh the DataGridView to reflect the changes
            dgvInvoiceList.Refresh();
        }
        


    }




}
