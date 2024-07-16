using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Client;
using Domain.Entities.Item;
using Domain.Entities.Request;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<RequestEntity> RequestEntities { get; set; }
        public DbSet<ItemEntity> ItemEntities { get; set; }
        public DbSet<ClientEntity> ClientEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Shop;User ID=sa;Password=<YourStrong@Passw0rd>; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
