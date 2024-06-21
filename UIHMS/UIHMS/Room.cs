using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHMS
{
    public partial class Room : UserControl
    {
        public Connection? Connection;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //loading of database objects
            this.Connection = new Connection();

            //this.dbContext.Database.EnsureDeleted();
            this.Connection.Database.EnsureCreated();

            this.Connection.Room.Load();

            this.roomTableBindingSource.DataSource = this.Connection.Room.Local.ToBindingList();

        }
        public Room()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
