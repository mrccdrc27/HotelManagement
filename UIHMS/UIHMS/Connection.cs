using Microsoft.EntityFrameworkCore;


// This Sets the creation of table to the database.
namespace UIHMS
{
    public class Connection : DbContext
    {

        // DbSet<Class> TableName 
        public DbSet<Room_Table> Room { get; set; }
        public DbSet<Category_Table> Category { get; set; } 
        public DbSet<Guest_Table> Guest { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = HMS.db"); //connection string and to use sqlite

    }
}
