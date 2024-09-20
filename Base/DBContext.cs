using Microsoft.EntityFrameworkCore;
using DB.Entities;

namespace DB
{
    public class DBContext : DbContext

    {
        public DBContext(DbContextOptions<DBContext> options) 
            : base(options) { 
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tale> Tales { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable(nameof(Category));
            modelBuilder.Entity<Tale>().ToTable(nameof(Tale));
            modelBuilder.Entity<User>().ToTable(nameof(User));

        }
    }
}
