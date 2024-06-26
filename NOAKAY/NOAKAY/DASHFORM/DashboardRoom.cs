using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NOAKAY.CLASSES;
using SQLCONNECTION;
using NOAKAY.CLASSES.Joined_Tables;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardRoom : Form
    {
        private Connection dbContext;

        public DashboardRoom()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


        }

        public void oldcode()
        {
            // Loading of database objects
            dbContext = new Connection();

            // Ensure database is created
            dbContext.Database.EnsureCreated();

            // Raw SQL query with CASE statement for RoomStatus
            string sqlQuery = @"
                SELECT RoomModels.RoomId,
                       CASE RoomModels.RoomStatus
                           WHEN 0 THEN 'Occupied'
                           WHEN 1 THEN 'Available'
                           WHEN 2 THEN 'Unavailable'
                           ELSE 'Unknown'  -- Handle any other values if necessary
                       END AS RoomStatus,
                       RoomModels.RoomNum,
                       CategoryModels.CategoryName
                FROM RoomModels
                INNER JOIN CategoryModels ON RoomModels.CategoryID = CategoryModels.CategoryID;";

            // Execute the query and map the results to DTO
            //var roomGuestCategoryList = dbContext.RoomCategoryDTO.FromSqlRaw(sqlQuery).ToList();

            // Bind data to BindingSource
            //roomModelBindingSource.DataSource = roomGuestCategoryList;

            // Set DataSource of DataGridView to BindingSource
            //dgvRoomList.DataSource = roomModelBindingSource;
        }

        private void btnUpdateRStatus_Click(object sender, EventArgs e)
        {
            new UpdateRoomStat().Show();
        }

        private void DashboardRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
