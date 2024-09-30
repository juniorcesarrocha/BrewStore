namespace BrewStore.Pagamento.Dominio
{
    public class PagamentoPixDominio : IPagamento
    {
        public PagamentoPixDominio(string codigoPix)
        {
            CodigoPix = codigoPix;
        }

        public bool Pagar()
        {
            return true;
        }

        public string CodigoPix { get; private set; }
    }
}
