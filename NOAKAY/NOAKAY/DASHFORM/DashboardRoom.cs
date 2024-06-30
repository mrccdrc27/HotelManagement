using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NOAKAY.CLASSES;
using SQLCONNECTION;
using NOAKAY.CLASSES.Joined_Tables;
using Microsoft.EntityFrameworkCore.Storage;

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
            //newcode();
            comboBox1.SelectedIndex = 0;
            CurrentFilter(newcode());

        }
        public List<RoomGuestModel> newcode()
        {
            dbContext = new Connection();

            // Ensure database is created
            dbContext.Database.EnsureCreated();

            var occupiedRoom = from Room in dbContext.RoomModels // Initial Join of Guest and Room
                               select new RoomGuestModel
                               {
                                   // IF Error, Data Must Be nulled, GO back and input data properly
                                   RoomId = Room.RoomID,
                                   GuestID = 0,
                                   Status = "0",
                                   CheckIn = null,
                                   CheckOut = null,

                               };

            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               // Initial Join of Guest and Room
                               select new RoomGuestModel
                               {
                                   // IF Error, Data Must Be nulled, GO back and input data properly
                                   RoomId = Room.RoomID,
                                   GuestID = Guest.GuestID,
                                   Status = $"{Guest.GuestStatus}",
                                   CheckIn = Guest.CheckIn,
                                   CheckOut = Guest.CheckOut
                               };
            var unionlist = combinedData.ToList().Union(occupiedRoom.ToList());


            //var combinedList = combinedData.ToList();

            foreach (var item in unionlist)
            {
                if (item.Status == "0")
                {
                    // Change GuestStatus if it is 1
                    item.Status = "Available"; // Example change to 3
                }
                else if (item.Status == "1" || item.Status == "2")
                {
                    // Change GuestStatus if it is 2
                    item.Status = "Occupied"; // Example change to 3
                }
                // Add more conditions as needed
            }


            this.dbContext.Database.CloseConnection();

            roomGuestModelBindingSource.DataSource = unionlist;
            return unionlist.ToList();

        }

        public void CurrentFilter(List<RoomGuestModel> roomGuest)
        {
            List<RoomGuestModel> printlist = new List<RoomGuestModel>();
            List<int> roomlist = new List<int>();
            foreach (var item in roomGuest)
            {
                if ((item.CheckIn >= DateTime.Now && item.CheckOut >= DateTime.Now) || (item.CheckIn <= DateTime.Now && item.CheckOut <= DateTime.Now))
                {
                    printlist.Add(item);
                    roomlist.Add(item.RoomId);
                }
                if (!roomlist.Contains(item.RoomId))
                {
                    printlist.Add(item);
                }
            }
            roomGuestModelBindingSource.DataSource = printlist.ToList();
        }

        public void TimespanFilter(List<RoomGuestModel> roomGuest, DateTime Start, DateTime End)
        {
            List<RoomGuestModel> printlist = new List<RoomGuestModel>();

            List<int> roomlist = new List<int>();
            foreach (var item in roomGuest)
            {
                if ((Start <= item.CheckIn && item.CheckOut <= End))
                {
                    printlist.Add(item);
                    roomlist.Add(item.RoomId);
                }
                if ((!roomlist.Contains(item.RoomId)) && (item.GuestID == 0))
                {
                    roomlist.Add(item.RoomId);
                    printlist.Add(item);
                }
            }
            roomGuestModelBindingSource.DataSource = printlist.ToList();
        }

        // == OLD CODE ==
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CurrentFilter(newcode());
            }
            if (comboBox1.SelectedIndex == 1)
            {
                TimespanFilter(newcode(), dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimespanFilter(newcode(), dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
