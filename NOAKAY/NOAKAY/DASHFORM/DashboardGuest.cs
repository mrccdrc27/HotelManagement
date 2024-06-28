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
    public partial class DashboardGuest : Form
    {
        private Connection dbContext;
        private List<GuestRoomCategoryDTO> allGuests; // To store the original list of guests

        public DashboardGuest()
        {
            InitializeComponent();
        }

        // == BINDING THE DATA TO DATA GRID VIEW ==
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // newcode();
            loadGuest(); // filter only guest that has 0 or 1 status, 2 means they are in booking list

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
                                   CheckOut = (DateTime)Guest.CheckIn!,
                                   CategoryName = Category.CategoryName!,
                                   GuestStatus = $"{Guest.GuestStatus}",
                                   Email = Guest.Email!

                               };

            var combinedList = combinedData.ToList();
            // allGuests = combinedList;
            List<GuestRoomCategoryDTO> filter = new List<GuestRoomCategoryDTO>();

            foreach (var item in combinedList)
            {

                if (item.GuestStatus == "0" )
                {
                    item.GuestStatus = "Check In";
                    filter.Add(item);
                }
                else if (item.GuestStatus == "1")
                {
                    item.GuestStatus = "Check Out";
                    filter.Add(item);
                }           
            }

            dgvGuestList.DataSource = filter;
            allGuests = filter;

        } // loadGuest

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new InsertGuest().Show();
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
            guestModelBindingSource.DataSource = filteredGuests;
            dgvGuestList.DataSource = guestModelBindingSource; // i add this to bind the data to dgv

            // Refresh the DataGridView to reflect the changes
            dgvGuestList.DataSource = filteredGuests;
            dgvGuestList.Refresh();
        }

        private void comboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combo box update;
            List<GuestRoomCategoryDTO> list = (List<GuestRoomCategoryDTO>)allGuests; // allGuest
            List<GuestRoomCategoryDTO> filter = new List<GuestRoomCategoryDTO>();
            // var num = 0;

            if (comboSearchStatus.SelectedIndex == 0)
            {
                foreach (var item in list)
                {
                    if (item.GuestStatus == "Check In")
                    {
                        filter.Add(item);
                    }
                }
            }
            if (comboSearchStatus.SelectedIndex == 1)
            {
                foreach (var item in list)
                {
                    if (item.GuestStatus == "Check Out")
                    {
                        filter.Add(item);
                    }
                }
            }
            if (comboSearchStatus.SelectedIndex == 2)
            {
                filter = list;
            }
            dgvGuestList.DataSource = filter;
        }
        //public void guestOnly()
        //{
        //    // default guest display
        //    dbContext = new Connection();

        //    // Ensure database is created
        //    dbContext.Database.EnsureCreated();
        //    this.dbContext.GuestModels.Load();
        //    guestRoomCategoryDTOBindingSource.DataSource = this.dbContext.GuestModels.Local.ToList();
        //    allGuests = guestRoomCategoryDTOBindingSource.DataSource as List<GuestRoomCategoryDTO>; // i add this to bind the data to dgv
        //}


        private void dgvGuestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvGuestList.Columns["Update"].Index)
            {
                // Get the data source of the DataGridView
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
                    //int guestStatusIndex = guestStatus == "1" ? 1 : 0;
                    // int guestStatus = Convert.ToInt32(selectedGuest.GuestStatus);

                    // Create an instance of the UpdateGuestInfo form
                    UpdateGuestInfo updateForm = new UpdateGuestInfo();

                    // Pass data to the UpdateGuestInfo form using LoadGuestInfo method
                    updateForm.LoadGuestInfo(guestId, lastName, firstName, middleName, suffix, address, contact, email, guestStatusIndex, checkIn, checkOut, roomId);

                    // Show the update form
                    updateForm.Show();

                    // After update form is closed, refresh the DataGridView if needed
                    dgvGuestList.Refresh(); // Or update specific row if you know which one changed
                }
            }
        }

    }
}

