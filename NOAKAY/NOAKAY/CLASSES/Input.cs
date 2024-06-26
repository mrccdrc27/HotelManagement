using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NOAKAY.CLASSES;
using NOAKAY.CLASSES.Joined_Tables;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONNECTION

{
    public class Connection : DbContext
    {
        public DbSet<PersonModel> PersonModels { get; set; }
        public DbSet<RoomModel> RoomModels { get; set; }
        public DbSet<CategoryModel> CategoryModels { get; set; }
        public DbSet<GuestModel> GuestModels { get; set; }
        public DbSet<BookingRecord> bookingRecordModel { get; set; }


        //public DbSet<RoomCategoryDTO> RoomCategoryDTO { get; set; } // inner join
        //public DbSet<GuestRoomCategoryDTO> GuestRoomCategoryDTO { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = NOAKAY_HOTEL.db"); // connection string and to use sqlite

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>().HasKey(p => p.AccountID);
            modelBuilder.Entity<GuestModel>().HasKey(p => p.GuestID);

            ////one active guest per room, roomnum > guestnum
            //int x = 0;
            //int guestnum = 10;
            //int roomnum = 20;
            //int categorynum = roomnum / 4;
            

            //////if it is not working change the numbers
            //////Generate Categories

            //var categories = new List<CategoryModel>();
            //for (int i = 0; i < categorynum; i++)
            //{
            //    categories.Add(new CategoryModel
            //    {
            //        CategoryID = i + 1,
            //        CategoryName = $"Tier{i + 1}",
            //        basePrice = 100 * (i + 1)

            //    });
            //}
            //modelBuilder.Entity<CategoryModel>().HasData(categories.ToArray());

            //////Generate Rooms

            //var room = new List<RoomModel>();
            //for (int i = 0; i < roomnum; i++)
            //{
            //    if (i % categorynum == 0)
            //    {
            //        x += 1;
            //    }
            //    room.Add(new RoomModel
            //    {
            //        RoomID = i + 1,
            //        RoomNum = (i + 1),
            //        CategoryId = (x),
                    
            //    });
            //}
            //modelBuilder.Entity<RoomModel>().HasData(room.ToArray());

            ////Generate guest
            //var rnd = new Random();

            //var guests = new List<GuestModel>();
            //for (int i = 0; i < guestnum; i++)
            //{
            //    guests.Add(new GuestModel
            //    {
            //        GuestStatus = 1,
            //        GuestID = i + 1,
            //        FirstName = "first" + i,
            //       LastName = "last" + i,
            //       RoomID = i + 1,
            //       CheckIn = DateTime.Now,
            //       CheckOut = DateTime.Now,
            //        Contact = $"{0}{9}{rnd.Next(1, 9)}{rnd.Next(1, 9)}{rnd.Next(1, 9)}{rnd.Next(1, 9)}{rnd.Next(1, 9)}{rnd.Next(1, 9)}{rnd.Next(1, 9)}",
            //    });
            //}
            //modelBuilder.Entity<GuestModel>().HasData(guests.ToArray());
        }

    }

}
