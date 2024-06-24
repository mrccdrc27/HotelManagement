using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NOAKAY.CLASSES;
using SQLCONNECTION;


namespace NOAKAY.DASHFORM
{
    public partial class DashboardGuest : Form
    {
        public Connection? dbContext;
        public DashboardGuest()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        // == BINDING THE DATA TO DATA GRID VIEW ==

        private List<GuestModel> allGuests; // Define this at the class level
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Loading of database objects
            this.dbContext = new Connection();
            this.dbContext.Database.EnsureCreated();

            // Load all guests into a list
            this.allGuests = this.dbContext.GuestModels.FromSqlRaw("SELECT * FROM GuestModels").ToList();

            // Modify the data to include GuestStatusDisplay
            var guestsWithDisplay = this.allGuests.Select(g => new
            {
                g.GuestID,
                g.FirstName,
                g.LastName,
                g.Email,
                GuestStatus = g.GuestStatusDisplay,
                g.CheckIn,
                g.CheckOut,
                g.Contact,
                g.Address,
                g.RoomID

            }).ToList();

            // Bind data to BindingSource
            this.guestModelBindingSource.DataSource = guestsWithDisplay;

            // Set DataSource of DataGridView to BindingSource
            this.dgvGuestList.DataSource = this.guestModelBindingSource;
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
                g.FirstName.ToLower().Contains(searchTerm) 
            // Add more conditions as needed for other properties
            ).Select(g => new
            {
                g.GuestID,
                g.FirstName,
                g.LastName,
                g.Email,
                GuestStatus = g.GuestStatusDisplay,
                g.CheckIn,
                g.CheckOut,
                g.Contact,
                g.Address,
                g.RoomID
            })
            .ToList();

            // Update the BindingSource with the filtered list
            guestModelBindingSource.DataSource = filteredGuests;

            // Refresh the DataGridView to reflect the changes
            dgvGuestList.Refresh();
        }

        private void comboSearchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedStatusIndex = comboSearchStatus.SelectedIndex;

            var filteredGuests = allGuests
                .Where(g =>
                 selectedStatusIndex == 2 || g.GuestStatus == selectedStatusIndex)
                .Select(g => new
                {
                    g.GuestID,
                    g.FirstName,
                    g.LastName,
                    g.Email,
                    GuestStatus = g.GuestStatusDisplay,
                    g.CheckIn,
                    g.CheckOut,
                    g.Contact,
                    g.Address,
                    g.RoomID
                })
                .ToList();

            // Update the BindingSource with the filtered list
            guestModelBindingSource.DataSource = filteredGuests;

            // Refresh the DataGridView to reflect the changes
            dgvGuestList.Refresh();
        }

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    string searchTerm = txtSearch.Text.ToLower();

        //    // Prepare the SQL query with a WHERE clause to filter based on search term
        //    string sqlQuery = $"SELECT * FROM GuestModels WHERE LOWER(Name) LIKE '%{searchTerm}%' OR LOWER(Email) LIKE '%{searchTerm}%'";

        //    // Execute raw SQL query and get the filtered guests
        //    var filteredGuests = this.dbContext.GuestModels.FromSqlRaw(sqlQuery).ToList();

        //    // Update the BindingSource with the filtered list
        //    guestModelBindingSource.DataSource = filteredGuests;

        //    // Refresh the DataGridView to reflect the changes
        //    dgvGuestList.Refresh();
        //}

    }
}
