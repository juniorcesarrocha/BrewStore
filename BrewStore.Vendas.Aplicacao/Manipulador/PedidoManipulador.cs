using BrewStore.Vendas.Aplicacao.Comando;
using BrewStore.Vendas.Dominio;
using BrewStore.Vendas.Dominio.Factory;
using BrewStore.Vendas.Dominio.Infraestrutura.Repositorio;
using MediatR;

namespace BrewStore.Vendas.Aplicacao.Manipulador
{
    public class PedidoManipulador :
        IRequestHandler<AdicionarProdutoPedidoComando, bool>
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;

        private readonly IMediator _mediator;

        public PedidoManipulador(IPedidoRepositorio pedidoRepositorio, IMediator mediator)
        {
            _pedidoRepositorio = pedidoRepositorio;
            _mediator = mediator;
        }

        public async Task<bool> Handle(AdicionarProdutoPedidoComando request, CancellationToken cancellationToken)
        {
            var pedido = await _pedidoRepositorio.ObterPedidoPorIdCliente(request.IdCliente);

            var novoPedidoItem = new PedidoItemDominio(DateTime.Now,
                    request.IdProduto,
                    request.Quantidade,
                    request.ValorUnitario,
                    request.QuantidadeMinimaDesconto,
                    request.ValorDescontoQuantidade,
                    request.DataDescontoSazonal,
                    request.PercentualDescontoSazonal);

            if (pedido is null)
            {
                pedido = PedidoFactory.CriarPedidoPendente(request.IdCliente);

                pedido.AdicionarProduto(novoPedidoItem);
            }
            else
            {
                var produtoExistePedido = pedido.ProdutoExistePedido(novoPedidoItem);

                if (produtoExistePedido)
                {
                    _pedidoRepositorio.AtualizarItem(pedido.PedidoItems.FirstOrDefault(p => p.IdProduto == novoPedidoItem.IdProduto));
                }
                else
                {
                    _pedidoRepositorio.AdicionarItem(novoPedidoItem);
                }
            }
            
            return await _pedidoRepositorio.UnitOfWork.Commit();
        }
    }
}
