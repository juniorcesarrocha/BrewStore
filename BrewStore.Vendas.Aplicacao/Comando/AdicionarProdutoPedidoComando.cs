using MediatR;

namespace BrewStore.Vendas.Aplicacao.Comando
{
    public class AdicionarProdutoPedidoComando : IRequest<bool>
    {
        public AdicionarProdutoPedidoComando(int idCliente, 
            int idProduto,
            decimal valorUnitario,
            int quantidade,
            int? quantidadeMinimaDesconto,
            decimal? valorDescontoQuantidade,
            DateTime? dataDescontoSazonal,
            decimal? percentualDescontoSazonal)
        {
            IdCliente = idCliente;

            IdProduto = idProduto;

            Quantidade = quantidade;

            ValorUnitario = valorUnitario;

            QuantidadeMinimaDesconto = quantidadeMinimaDesconto;

            ValorDescontoQuantidade = valorDescontoQuantidade;

            DataDescontoSazonal = dataDescontoSazonal;

            PercentualDescontoSazonal = percentualDescontoSazonal;
        }

        public int IdCliente { get; private set; }

        public int IdProduto { get; private set; }

        public int Quantidade { get; private set; }

        public decimal ValorUnitario { get; private set; }

        public int? QuantidadeMinimaDesconto { get; private set; }

        public decimal? ValorDescontoQuantidade { get; private set; }

        public DateTime? DataDescontoSazonal { get; private set; }

        public decimal? PercentualDescontoSazonal { get; private set; }
    }
}
