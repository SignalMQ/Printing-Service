using BL.Objects;
using Microsoft.EntityFrameworkCore;

namespace BL.MyDbContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        // entities
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // this connection string must be override  
            optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=Printing_Service; user id=postgres; password=quvonch11");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
