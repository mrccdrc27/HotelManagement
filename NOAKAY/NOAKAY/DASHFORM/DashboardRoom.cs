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
using SQLCONNECTION;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardRoom : Form
    {
        public Connection? dbContext;
        public DashboardRoom()
        {
            InitializeComponent();
        }

        private List<RoomModel> allRooms; // Define this at the class level
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //loading of database objects
            this.dbContext = new Connection();

            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
            this.allRooms = this.dbContext.RoomModels.FromSqlRaw("SELECT * FROM RoomModels").ToList();
            // Modify the data to include RoomStatusDisplay
            var roomsWithDisplay = this.allRooms.Select(r => new
            {
                r.RoomID,
                r.CategoryId,
                RoomStatus = r.RoomStatusDisplay,
                r.RoomNum

            }).ToList();

            // Bind data to BindingSource
            this.roomModelBindingSource.DataSource = roomsWithDisplay;

            // Set DataSource of DataGridView to BindingSource
            this.dgvRoomList.DataSource = this.roomModelBindingSource;
        }
    }
}
