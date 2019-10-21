using LearningAngular.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningAngular.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(h => h.Id);
            builder
                .Property(h => h.DataPedido)
                .IsRequired();

            builder
                .Property(h => h.UsuarioId)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(h => h.CEP)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(h => h.EnderecoCompleto)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(h => h.NumeroEndereco)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(h => h.Cidade)
                .HasMaxLength(180)
                .IsRequired();

            builder
                .Property(h => h.Estado)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(h => h.FormaPagamento)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
