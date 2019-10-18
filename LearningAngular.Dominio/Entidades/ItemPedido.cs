namespace LearningAngular.Dominio.Entidades
{
    public class ItemPedido :Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if(ProdutoId == 0)
            {
                AdicionarMensagemValidacao("Não foi identificado o Produto");
            }
            if (Quantidade == 0)
            {
                AdicionarMensagemValidacao("Quantidade não informada");
            }
        }
    }
}
