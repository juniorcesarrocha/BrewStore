namespace BrewStore.Vendas.Dominio
{
    public class PedidoItemDominio
    {
        public PedidoItemDominio()
        {
            
        }

        public PedidoItemDominio(DateTime dataCompra,
            int idProduto, 
            int quantidade, 
            decimal valorUnitario, 
            int? quantidadeMinimaDesconto, 
            decimal? valorDescontoQuantidade,
            DateTime? dataDescontoSazonal,
            decimal? percentualDescontoSazonal)
        {
            DataCompra = dataCompra;

            IdProduto = idProduto;

            Quantidade = quantidade;    

            ValorUnitario = valorUnitario;

            QuantidadeMinimaDesconto = quantidadeMinimaDesconto;

            ValorDescontoQuantidade = valorDescontoQuantidade;

            DataDescontoSazonal = dataDescontoSazonal;

            PercentualDescontoSazonal = percentualDescontoSazonal;
        }

        public int Id { get; private set; }

        public int IdPedido { get; private set; }

        public DateTime DataCompra { get; private set; }

        public int IdProduto { get; private set; }
        
        public int Quantidade { get; private set; }
        
        public decimal ValorUnitario { get; private set; }

        public int? QuantidadeMinimaDesconto { get; private set; }

        public decimal? ValorDescontoQuantidade { get; private set; }

        public DateTime? DataDescontoSazonal { get; private set; }

        public decimal? PercentualDescontoSazonal { get; private set; }

        public PedidoDominio Pedido { get;  set; }

        public void VincularPedido(int idPedido)
        {
            IdPedido = idPedido;
        }

        public decimal CalcularValor()
        {
            decimal valorTotalItem = Quantidade * ValorUnitario;

            if (Quantidade >= QuantidadeMinimaDesconto)
            {
                valorTotalItem -= ValorDescontoQuantidade.HasValue ? ValorDescontoQuantidade.Value : 0;
            }

            if (DataDescontoSazonal.HasValue && DataCompra == DataDescontoSazonal.Value)
            {
                valorTotalItem -= (PercentualDescontoSazonal.HasValue ? PercentualDescontoSazonal.Value / 100M : 0);
            }

            return valorTotalItem;
        }

        public void AdicionarQuantidade(int unidades)
        {
            Quantidade += unidades;
        }

        public void AtualizarQuantidade(int unidades)
        {
            Quantidade = unidades;
        }
    }
}
