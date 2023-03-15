global using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Web_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<SuperHero> SUPERHERO { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<GroupPermissions>().HasKey(p => new { p.PERID, p.GROUPID });
        }
    }
}
