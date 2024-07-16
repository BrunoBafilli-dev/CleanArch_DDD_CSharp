using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.EntityFramework.Mappings
{
    public class RequestItemEntityMap : IEntityTypeConfiguration<RequestItemEntity>
    {
        public void Configure(EntityTypeBuilder<RequestItemEntity> builder)
        {
            // Tabela
            builder.ToTable("RequestItem");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //Chave estrangeira
            builder.HasIndex(x => x.Id);

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);


            // Propriedades
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("INTEGER")
                .HasMaxLength(80);

            //Value object
            builder.OwnsOne(p => p.QuantityItem, pv =>
            {
                pv.Property(x => x.Quantity)
                    .IsRequired()
                    .HasColumnName("QuantityItem")
                    .HasColumnType("INTEGER");
            });


            //Value object
            builder.OwnsOne(p => p.PriceItem, pv =>
            {
                pv.Property(x => x.Price)
                    .IsRequired()
                    .HasColumnName("Price")
                    .HasColumnType("DECIMAL(18,2)");
            });

            builder.HasOne(x => x.RequestEntity)
                .WithMany(x => x.RequestItensEntities)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
