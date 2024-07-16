using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.EntityFramework.Mappings
{
    public class ClientEntityMap : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            // Tabela
            builder.ToTable("Client");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //Value object
            builder.OwnsOne(p => p.Address, pv =>
            {
                pv.Property(x => x.Number)
                    .IsRequired()
                    .HasColumnName("Address_Number")
                    .HasColumnType("NVARCHAR");
            });
            //Value object
            builder.OwnsOne(p => p.Address, pv =>
            {
                pv.Property(x => x.Road)
                    .IsRequired()
                    .HasColumnName("Address_Road")
                    .HasColumnType("NVARCHAR");
            });

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
        }
    }
}
