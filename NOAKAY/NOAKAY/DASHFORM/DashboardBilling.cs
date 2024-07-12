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
using NOAKAY.CLASSES;
using NOAKAY.CLASSES.Joined_Tables;
using SQLCONNECTION;
using NOAKAY.DASHFORM;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardBilling : Form
    {
        private Connection dbContext;
        private List<GuestRoomCategoryDTO> allGuests; // To store the original list of guests
        public DashboardBilling()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadGuest();

        }

        public void loadGuest()
        {
            this.dbContext = new Connection();
            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               //Initial Join of Guest and Room
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new GuestRoomCategoryDTO
                               {
                                   //IF Error, Data Must Be nulled, GO back and input data properly
                                   RoomID = Room.RoomID,
                                   GuestID = Guest.GuestID,
                                   RoomNum = Room.RoomNum,
                                   LastName = Guest.LastName!,
                                   FirstName = Guest.FirstName!,
                                   MiddleName = Guest.MiddleName!, // new
                                   Suffix = Guest.Suffix!, // new
                                   Address = Guest.Address!,
                                   Contact = Guest.Contact!,
                                   CheckIn = (DateTime)Guest.CheckIn!,
                                   CheckOut = (DateTime)Guest.CheckOut!,
                                   CategoryName = Category.CategoryName!,
                                   GuestStatus = $"{Guest.GuestStatus}",
                                   Email = Guest.Email!

                               };

            var combinedList = combinedData.ToList();
            // allGuests = combinedList;
            List<GuestRoomCategoryDTO> filter = new List<GuestRoomCategoryDTO>();
            foreach (var item in combinedList)
            {

                if (item.GuestStatus == "0")
                {
                    item.GuestStatus = "Check In";

                    filter.Add(item);
                }
                else if (item.GuestStatus == "1")
                {
                    item.GuestStatus = "Check Out";
                    filter.Add(item);
                }
                else
                {
                    item.GuestStatus = "Pending";
                    filter.Add(item);
                }
            }

            dgvGuestList.DataSource = filter;
            allGuests = filter;


        } // loadGuest

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            // Filter the original list based on the search term
            var filteredGuests = allGuests.Where(g =>
                g.LastName.ToLower().Contains(searchTerm) ||
                g.FirstName.ToLower().Contains(searchTerm)

            ).ToList();

            // Update the BindingSource with the filtered list
            //   guestModelBindingSource.DataSource = filteredGuests;
            //   dgvGuestList.DataSource = guestModelBindingSource; // i add this to bind the data to dgv

            // Refresh the DataGridView to reflect the changes
            dgvGuestList.DataSource = filteredGuests;
            dgvGuestList.Refresh();
        }

        private void dgvGuestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvGuestList.Columns["Payment"].Index)
            {
                List<GuestRoomCategoryDTO> dataSource = dgvGuestList.DataSource as List<GuestRoomCategoryDTO>;
                if (dataSource != null)
                {
                    // Retrieve data from the original data source based on the row index
                    GuestRoomCategoryDTO selectedGuest = dataSource[e.RowIndex];

                    // Extract the necessary data
                    int guestId = selectedGuest.GuestID;
                    int roomId = selectedGuest.RoomID;
                    string lastName = selectedGuest.LastName;
                    string firstName = selectedGuest.FirstName;
                    string middleName = selectedGuest.MiddleName;
                    string suffix = selectedGuest.Suffix;
                    string email = selectedGuest.Email;
                    string contact = selectedGuest.Contact;
                    string address = selectedGuest.Address;
                    DateTime checkIn = selectedGuest.CheckIn;
                    DateTime checkOut = selectedGuest.CheckOut;
                    string guestStatus = selectedGuest.GuestStatus;
                    int guestStatusIndex;
                    if (guestStatus == "Check In")
                    {
                        guestStatusIndex = 0;
                    }
                    else if (guestStatus == "Check Out")
                    {
                        guestStatusIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                        // Handle unexpected values (set to a default value or show an error message)
                        guestStatusIndex = 1; // Invalid index, ensure combo box can handle this
                    }
                    InsertBillingInfo updateForm = new InsertBillingInfo();

                    // Pass data to the UpdateGuestInfo form using LoadGuestInfo method
                    updateForm.LoadGuestInfo(guestId, lastName, firstName, middleName, suffix, address, contact, email, guestStatusIndex, checkIn, checkOut, roomId);

                    // Show the update form
                    updateForm.Show();

                    // After update form is closed, refresh the DataGridView if needed
                    dgvGuestList.Refresh(); // Or update specific row if you know which one changed

                } // if
            } // if
        } // cell content

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            GenerateInvoice();
        }

        public void GenerateInvoice()
        {

        } // GenerateInvoice
    }
}
