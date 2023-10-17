using BL.Objects;
using Microsoft.EntityFrameworkCore;

namespace BL.Base
{
    /// <summary>
    /// Realization of database interface with Entity Queryes
    /// </summary>
    public class DBase: DbContext
    {
        public string connectionString = "Data Source=base.db;";
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DBase() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
