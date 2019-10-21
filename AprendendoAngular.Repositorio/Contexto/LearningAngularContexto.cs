using JetBrains.Annotations;
using LearningAngular.Dominio.Entidades;
using LearningAngular.Dominio.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;

namespace LearningAngular.Repositorio.Contexto
{
    public class LearningAngularContexto : DbContext
    {
     

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }




        public LearningAngularContexto(DbContextOptions options) : base(options)
        {

        }



    }
}
