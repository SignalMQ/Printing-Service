using BL.Objects;
using Microsoft.EntityFrameworkCore;

namespace BL.Base
{
    /// <summary>
    /// This class realizes a base for application
    /// </summary>
    public class DBase: DbContext //must have
    {
        public string connectionString = "Data Source=base.db"; //main connection string, ps. base file name
        public DbSet<User> Users { get; set; } //Users table in base.db
        public DbSet<Request> Requests { get; set; } //Requests table in base.db
        public DBase() => Database.EnsureCreated(); //Check if base is created, otherwise it's creates new..

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //EF Core standart ovveride method for creating DataContext
        {
            optionsBuilder.UseSqlite(connectionString); //Using the Sqlite base for connecting, it's changed to other base type if needed...
        }
    }
}
