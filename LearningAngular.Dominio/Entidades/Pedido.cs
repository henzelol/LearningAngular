using LearningAngular.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningAngular.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }



        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarMensagemValidacao("O pedido não pode ter Nenhum pedido!!");
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarMensagemValidacao("O CEP deve estar preenchido");
            }
            if(FormaPagamentoId == 0)
            {
                AdicionarMensagemValidacao("Não foi informado a forma de pagamento");
            }
        }

    }

}
