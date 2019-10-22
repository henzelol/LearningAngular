using LearningAngular.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningAngular.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(h => h.Email)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(h => h.Senha)
                .HasMaxLength(400)
                .IsRequired();
            builder.Property(h => h.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(h => h.SobreNome)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(h => h.Pedidos)
                .WithOne(e => e.Usuario);

        }
    }
}
