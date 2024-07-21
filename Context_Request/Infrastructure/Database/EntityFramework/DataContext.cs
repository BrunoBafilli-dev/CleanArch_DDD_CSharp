using Domain.Request.Entities.Client;
using Domain.Request.Entities.Item;
using Domain.Request.Entities.Request;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Request.Database.EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<RequestEntity> RequestEntities { get; set; }
        public DbSet<ItemEntity> ItemEntities { get; set; }
        public DbSet<ClientEntity> ClientEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options){
           options.UseSqlServer("Server=localhost,1433;Database=Shop;User ID=sa;Password=<YourStrong@Passw0rd>; TrustServerCertificate=True;");
           options.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
