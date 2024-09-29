namespace BrewStore.Vendas.Dominio
{
    public class PedidoDominio
    {
        public PedidoDominio()
        {
            _pedidoItems = new List<PedidoItemDominio>();
        }

        public PedidoDominio(int idCliente)
        {
            IdCliente = idCliente;

            _pedidoItems = new List<PedidoItemDominio>();

            IdSituacao = (int)PedidoSituacaoDominio.Pendente;
        }

        public int Id { get; private set; }

        public int IdCliente { get; private set; }

        public DateTime Data { get; private set; }

        public int IdSituacao { get; private set; }

        public decimal ValorTotal { get; private set; }

        private readonly List<PedidoItemDominio> _pedidoItems;
        public IReadOnlyCollection<PedidoItemDominio> PedidoItems => _pedidoItems;

        public void CalcularValorTotalPedido()
        {
            ValorTotal = PedidoItems.Sum(p => p.CalcularValor());
        }

        public void AdicionarProduto(PedidoItemDominio item)
        {
            item.VincularPedido(Id);

            if (ProdutoExistePedido(item))
            {
                var produtoExistente = _pedidoItems.FirstOrDefault(p => p.IdProduto == item.IdProduto);

                produtoExistente.AdicionarQuantidade(item.Quantidade);

                item = produtoExistente;

                _pedidoItems.Remove(produtoExistente);
            }
            
            _pedidoItems.Add(item);

            CalcularValorTotalPedido();
        }

        public bool ProdutoExistePedido(PedidoItemDominio item)
        {
            return _pedidoItems.Any(p => p.IdProduto == item.IdProduto);
        }
    }
}
