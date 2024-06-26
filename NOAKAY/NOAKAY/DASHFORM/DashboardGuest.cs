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
            allGuests = dbContext.GuestRoomCategoryDTO.FromSqlRaw(sqlQuery).ToList();

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
            int selectedStatusIndex = comboSearchStatus.SelectedIndex;

            var filteredGuests = allGuests.Where(g =>
                selectedStatusIndex == 0 || // Assuming index 0 is for 'All' or similar
                (selectedStatusIndex == 0 && g.GuestStatus == "Check In") ||
                (selectedStatusIndex == 1 && g.GuestStatus == "Check Out")
            ).ToList();

            // Update the BindingSource with the filtered list
            guestModelBindingSource.DataSource = filteredGuests;

            // Refresh the DataGridView to reflect the changes
            dgvGuestList.Refresh();
        }
    }
}
