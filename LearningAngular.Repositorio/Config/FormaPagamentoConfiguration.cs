using LearningAngular.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningAngular.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(h => h.Id);
            builder
                .Property(h => h.Nome)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(h => h.Descricao)
                .HasMaxLength(180)
                .IsRequired();
            builder
                .Property(h => h.IsBoleto)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(h => h.IsCartaoCredito)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(h => h.IsDeposito)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(h => h.IsNaoDefinido)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
