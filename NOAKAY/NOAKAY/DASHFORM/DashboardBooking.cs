using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOAKAY.CLASSES.Joined_Tables;
using SQLCONNECTION;

namespace NOAKAY.DASHFORM
{

    public partial class DashboardBooking : Form
    {
        private Connection dbContext;
        public DashboardBooking()
        {
            InitializeComponent();
            Loadinvoce();

        }
        public void Loadinvoce()
        {

            this.dbContext = new Connection();

            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               //Initial Join of Guest and Room
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new Invoice
                               {
                                   fullName = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
                                   guestID = Guest.GuestID,
                                   checkIn = Guest.CheckIn,
                                   checkOut = Guest.CheckOut,
                                   price = ((Guest.CheckOut.Value).Day - (Guest.CheckIn.Value).Day) * Category.basePrice,
                                   roomName = Room.RoomNum,
                               };
            var combinedList = combinedData.ToList();

            //dgvInvoiceList.DataSource = combinedList;
            invoiceBindingSource.DataSource = combinedList;
        }



    }




}
