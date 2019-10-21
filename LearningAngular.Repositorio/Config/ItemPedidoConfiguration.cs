using LearningAngular.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LearningAngular.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(h => h.Id);
            builder
                .Property(h => h.ProdutoId)
                .IsRequired();

            builder
                .Property(h => h.Quantidade)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
