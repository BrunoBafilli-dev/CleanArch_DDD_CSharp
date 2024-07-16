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
    public class RequestEntityMap : IEntityTypeConfiguration<RequestEntity>
    {
        public void Configure(EntityTypeBuilder<RequestEntity> builder)
        {
            // Tabela
            builder.ToTable("Request");

            // Chave Primária
            builder.HasKey(x => x.Id);

            //Chave Estrangeira
            builder.HasIndex(x => x.ClientId);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.ClientId)
                .IsRequired()
                .HasColumnName("ClientId")
                .HasColumnType("INTEGER")
                .HasMaxLength(80);

            builder.HasMany(x => x.RequestItensEntities)
                .WithOne(x => x.RequestEntity)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Ignore(x => x.RequestCreatedDomainEvents);
        }
    }
}
