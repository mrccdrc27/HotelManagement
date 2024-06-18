using HOTEL_LOGIN;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SQLCONNECTION

{
    public class Connection : DbContext
    {
        public DbSet<PersonModel> PersonModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = HOTEL_LOG.db"); //connection string and to use sqlite

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>().HasKey(p => p.AccountID);
        }

        // Data to Database

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>().HasData(
                new PersonModel { AccountID = 1, Username = "Marco", Password = "password"}
                );
        }
        */


    }
}
