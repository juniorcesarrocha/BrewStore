namespace BrewStore.Pagamento.Dominio
{
    public class PagamentoDominio
    {
        private readonly IPagamento _pagamento;

        public PagamentoDominio(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public bool Pagar()
        {
           return _pagamento.Pagar();
        }
    }
}
