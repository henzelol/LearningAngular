using System.Collections.Generic;

namespace LearningAngular.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }


        public virtual ICollection<Pedido>  Pedidos { get; set; } // Um usuário pode ter nenhum ou vários pedidos

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarMensagemValidacao("Email não foi informado");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarMensagemValidacao("Senha não foi informada");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagemValidacao("Nome não foi informado");
            }
        }
    }
}
