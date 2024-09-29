namespace BrewStore.Vendas.Dominio
{
    public enum PedidoSituacaoDominio
    {
        Pendente = 0,
        AguardandoProcessamento = 1,
        ProcessandoPagamento = 2,
        PagamentoConcluido = 3,
        Estorno = 4,
        Cancelado = 5,
        SeparandoPedido = 6,
        Concluido = 7,
        AguardandoEstoque = 8,
    }
}
