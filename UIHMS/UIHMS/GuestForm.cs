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
using System.ComponentModel;

namespace UIHMS
{
    public partial class GuestForm : UserControl
    {

        private Connection? Connection;

        public GuestForm()
        {
            InitializeComponent();
            //LoadData();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //loading of database objects
            this.Connection = new Connection();

            //this.dbContext.Database.EnsureDeleted();
            this.Connection.Database.EnsureCreated();

            this.Connection.Guest.Load();

            this.guestTableBindingSource.DataSource = this.Connection.Guest.Local.ToBindingList();

        }

        private void LoadData()
        {
            using (var context = new Connection())
            {
                var guests = context.Guest.ToList();
                dataGridView1.DataSource = guests;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
