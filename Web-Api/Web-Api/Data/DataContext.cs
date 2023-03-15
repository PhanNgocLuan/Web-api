global using Microsoft.EntityFrameworkCore;

namespace Web_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle(@"User Id=luanpn;Password=luanpn@123;Data Source=localhost:1521/cdb1;");

        }
    }
}
