using CourierServiceDotnet.Services.Authentication.Infrastructure.DBEntities;
using CourierServiceDotnet.Services.Courier.Infrastructure.Entities;
using CourierServiceDotnet.Services.User.Infrastructure.DBEntities;
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
            modelBuilder.Entity<UserDB>();
            modelBuilder.Entity<AuthDB>(entity =>
            {
                entity.HasKey(c => c.UserId);
                entity.Property(c => c.UserId).IsRequired();

                entity.HasOne<UserDB>().WithOne().HasForeignKey<AuthDB>("FK_Auth_User");
            });
        }
    }
}