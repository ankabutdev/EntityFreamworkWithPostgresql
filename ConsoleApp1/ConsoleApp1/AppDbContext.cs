using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(DbConstans.DB_CONNECTIONSTRING);
        }
    }
}
