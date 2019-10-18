using System.Collections.Generic;

namespace LearningAngular.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }


        public ICollection<Pedido>  Pedidos { get; set; } // Um usuário pode ter nenhum ou vários pedidos
    }
}
