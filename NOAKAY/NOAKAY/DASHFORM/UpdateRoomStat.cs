using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOAKAY.CLASSES;
using SQLCONNECTION;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NOAKAY.DASHFORM
{
    public partial class UpdateRoomStat : Form
    {
        public Connection dbContext;

        public UpdateRoomStat()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext = new Connection();  // Connects to the database
                this.dbContext.Database.EnsureCreated(); // Ensure database is created

                int roomid = (int)comboRoomNo.SelectedIndex + 1;
                int roomstatus = comboRoomStat.SelectedIndex;

                // Fetch the room to be updated
                var roomToUpdate = dbContext.RoomModels.FirstOrDefault(r => r.RoomID == roomid);

                if (roomToUpdate != null)
                {
                    roomToUpdate.RoomStatus = roomstatus;

                    // Save changes to the database
                    dbContext.SaveChanges();
                    MessageBox.Show("Successful Room Status Update!");
                }
                else
                {
                    MessageBox.Show("Room not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                dbContext?.Dispose();
            }

            this.Close();
        }
    }
}
