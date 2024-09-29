namespace BrewStore.Vendas.Dominio.Factory
{
    public static class PedidoFactory
    {
        public static PedidoDominio CriarPedidoPendente(int idCliente)
        {
            return new PedidoDominio(idCliente);
        }
    }
}
