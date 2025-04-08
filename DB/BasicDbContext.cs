using Learn.AspNetCore.Basic.Models;
using Microsoft.EntityFrameworkCore;

namespace Learn.AspNetCore.Basic.DB
{
    public class BasicDbContext:DbContext
    {
        public BasicDbContext(DbContextOptions<BasicDbContext> options):base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
