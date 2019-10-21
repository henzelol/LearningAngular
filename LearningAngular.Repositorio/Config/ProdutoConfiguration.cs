using LearningAngular.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningAngular.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(h => h.Descricao)
                .HasMaxLength(400)
                .IsRequired();
            builder.Property(h => h.Preco)
                .IsRequired();
        }
    }
}
