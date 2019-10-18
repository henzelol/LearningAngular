using System.Collections.Generic;
using System.Linq;

namespace LearningAngular.Dominio.Entidades
{
    public abstract class Entidade
    {
        protected List<string> _mensagensValidacao { get; set; }
        public List<string> MensagemValidacao
        {
            get
            {
                return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());
            }
        }
        public abstract void Validate();
        public bool IsValidado {
            get
            {
                return !MensagemValidacao.Any();
            }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarMensagemValidacao(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

    }
}
