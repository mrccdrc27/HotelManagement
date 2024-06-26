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
            newcode();

        }

        public void newcode()
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
                                   Contact = Guest.Contact!,
                                   CheckIn = (DateTime)Guest.CheckIn!,
                                   CheckOut = (DateTime)Guest.CheckIn!,
                                   CategoryName = Category.CategoryName!,
                                   GuestStatus = $"{Guest.GuestStatus}"

                               };

            var combinedList = combinedData.ToList();

            foreach (var item in combinedList)
            {
                if (item.GuestStatus == "1")
                {
                    // Change GuestStatus if it is 1
                    item.GuestStatus = "Check Out"; // Example change to 3
                }
                else if (item.GuestStatus == "0")
                {
                    // Change GuestStatus if it is 2
                    item.GuestStatus = "Check In"; // Example change to 3
                }
                // Add more conditions as needed
            }


            this.dbContext.Database.CloseConnection();

            guestRoomCategoryDTOBindingSource.DataSource = combinedList;
        }
        public void guestOnly()
        {
            //deafult guest display
            dbContext = new Connection();

            // Ensure database is created
            dbContext.Database.EnsureCreated();
            this.dbContext.GuestModels.Load();
            guestRoomCategoryDTOBindingSource.DataSource = this.dbContext.GuestModels.Local.ToList();
        }

        public void oldcode()
        {
            // Loading of database objects
            dbContext = new Connection();

            // Ensure database is created
            dbContext.Database.EnsureCreated();

            string sqlQuery = @"
                Select GuestModels.GuestID
                    , GuestModels.LastName
                    , GuestModels.FirstName
                    , Guestmodels.middlename
                    , guestmodels.suffix
                    , guestmodels.address
                    , guestmodels.contact
                    , guestmodels.email
                    , CASE GuestModels.GuestStatus
                        WHEN 0 THEN 'Check In'
                        WHEN 1 THEN 'Check Out'
                        ELSE 'Unknown'
                      END AS GuestStatus
                    , guestmodels.checkin
                    , guestmodels.checkout
                    , guestmodels.roomid
                    , roommodels.roomnum
                    , categorymodels.categoryid
                    , categorymodels.categoryname
                FROM GuestModels
                INNER JOIN RoomModels ON GuestModels.RoomID = RoomModels.RoomID
                INNER JOIN CategoryModels ON RoomModels.CategoryID = CategoryModels.CategoryID;";

            // Execute the query and map the results to DTO
            //allGuests = dbContext.RoomModels.FromSqlRaw(sqlQuery).ToList();

            // Bind data to BindingSource
            guestModelBindingSource.DataSource = allGuests;

            // Set DataSource of DataGridView to BindingSource
            dgvGuestList.DataSource = guestModelBindingSource.DataSource;
        }

        // == BINDING THE DATA TO DATA GRID VIEW ==

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
                g.Email.ToLower().Contains(searchTerm) ||
                g.FirstName.ToLower().Contains(searchTerm) ||
                g.MiddleName.ToLower().Contains(searchTerm) ||
                g.Suffix.ToLower().Contains(searchTerm) ||
                g.Address.ToLower().Contains(searchTerm) ||
                g.Contact.ToLower().Contains(searchTerm) ||
                g.RoomNum.ToString().Contains(searchTerm) ||
                g.RoomID.ToString().Contains(searchTerm) ||
                g.CategoryName.ToLower().Contains(searchTerm)
            ).ToList();

            // Update the BindingSource with the filtered list
            guestModelBindingSource.DataSource = filteredGuests;

            // Refresh the DataGridView to reflect the changes
            dgvGuestList.Refresh();
        }

        private void comboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo box update;
            List<GuestRoomCategoryDTO> list = (List<GuestRoomCategoryDTO>)guestRoomCategoryDTOBindingSource.DataSource;
            List<GuestRoomCategoryDTO> filter = new List<GuestRoomCategoryDTO>();
            var num = 0;

            if(comboSearchStatus.SelectedIndex == 0)
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
            if (comboSearchStatus.SelectedIndex == 1)
            {
                filter = list;
            }
            dgvGuestList.DataSource = filter;
        }

        private void dgvGuestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
