namespace TodoApi.Models
{
    using Microsoft.EntityFrameworkCore;
    
    public class DBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
