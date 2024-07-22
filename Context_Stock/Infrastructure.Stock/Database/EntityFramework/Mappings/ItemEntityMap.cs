using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Stock.Entities.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Stock.Database.EntityFramework.Mappings
{

    public class ItemEntityMap : IEntityTypeConfiguration<ItemEntity>
    {
        public void Configure(EntityTypeBuilder<ItemEntity> builder)
        {
            // Tabela
            builder.ToTable("Item");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            //Value object
            builder.OwnsOne(p => p.QuantityItemStock, pv =>
            {
                pv.Property(x => x.Quantity)
                    .IsRequired()
                    .HasColumnName("QuantityItem")
                    .HasColumnType("INTEGER");
            });

            builder.OwnsOne(p => p.PriceItem, pv =>
            {
                pv.Property(x => x.Price)
                    .IsRequired()
                    .HasColumnName("PriceItem")
                    .HasColumnType("DECIMAL(18,2)");
            });
        }
    }
}
