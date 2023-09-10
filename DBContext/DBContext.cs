using CourierServiceDotnet.Services.Courier.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourierServiceDotnet.DBContext
{
    public class DataBaseContext : DbContext
    {
        private readonly IConfiguration _config;
        public DataBaseContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        public DbSet<CourierDB> Courier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"), options => options.EnableRetryOnFailure());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CouriersSchema");
            modelBuilder.Entity<CourierDB>();
            // .HasBaseType<User>();
        }
    }
}