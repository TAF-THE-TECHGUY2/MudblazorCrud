using Microsoft.EntityFrameworkCore;

namespace Mudsql.Models
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"));
        }

        public DbSet<Employment> employments { get; set; }  
    }
}
