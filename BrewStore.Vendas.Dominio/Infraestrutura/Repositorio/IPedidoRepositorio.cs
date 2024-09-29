using BrewStore.Core.Infraestrutura.Repositorio;

namespace BrewStore.Vendas.Dominio.Infraestrutura.Repositorio
{
    public interface IPedidoRepositorio : IRepositorio<PedidoDominio>
    {
        Task<PedidoDominio> ObterPedidoPorIdCliente(int idCliente);
        void Adicionar(PedidoDominio pedido);
        void Atualizar(PedidoDominio pedido);

        void AdicionarItem(PedidoItemDominio pedidoItem);

        void AtualizarItem(PedidoItemDominio pedidoItem);
    }
}
