using BrewStore.Core.Infraestrutura.Repositorio;
using BrewStore.Vendas.Dominio;
using BrewStore.Vendas.Dominio.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BrewStore.Vendas.Infraestrutura.Repositorio
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private readonly VendasContext _context;

        public PedidoRepositorio(VendasContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<PedidoDominio> ObterPedidoPorIdCliente(int idCliente)
        {
            var pedido = await _context.Pedidos.FirstOrDefaultAsync(p => p.IdCliente == idCliente && p.IdSituacao == (int)PedidoSituacaoDominio.Pendente);

            if (pedido is null) return null;

            await _context.Entry(pedido)
                .Collection(p => p.PedidoItems).LoadAsync();

            return pedido;
        }

        public void Adicionar(PedidoDominio pedido)
        {
            _context.Pedidos.Add(pedido);
        }

        public void Atualizar(PedidoDominio pedido)
        {
            _context.Pedidos.Update(pedido);
        }

        public void AdicionarItem(PedidoItemDominio pedidoItem)
        {
            _context.PedidoItems.Add(pedidoItem);
        }
        public void AtualizarItem(PedidoItemDominio pedidoItem)
        {
            _context.PedidoItems.Update(pedidoItem);
        }
    }
}
