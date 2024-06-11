using Blush.Models;
using Microsoft.EntityFrameworkCore;

namespace Blush.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1, Name = "Fackpack", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Lipstick", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Foundation", DisplayOrder = 3 }
                );
        }

    }
   
}
