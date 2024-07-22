using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Entities.Item;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Stock.Database.EntityFramework
{
    public class ItemDataContext : DbContext
    {
        public DbSet<ItemEntity> ItemEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Shop;User ID=sa;Password=<YourStrong@Passw0rd>; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ItemDataContext).Assembly);
        }
    }
}
