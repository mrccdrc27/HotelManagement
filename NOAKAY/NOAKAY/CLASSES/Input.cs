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
        public DbSet<RoomCategoryDTO> RoomCategoryDTO { get; set; } // inner join
        public DbSet<GuestRoomCategoryDTO> GuestRoomCategoryDTO { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = NOAKAY_HOTEL.db"); // connection string and to use sqlite

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>().HasKey(p => p.AccountID);
            modelBuilder.Entity<GuestModel>().HasKey(p => p.GuestID);
        }

    }
}
