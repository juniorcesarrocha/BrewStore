namespace BrewStore.Pagamento.Dominio
{
    public class PagamentoCartaoDominio : IPagamento
    {
        public PagamentoCartaoDominio(string numeroCartao, 
            string nomeCliente, 
            string codigoSeguracao, 
            string mesAnoValidade, 
            int parcelas)
        {
            NumeroCartao = numeroCartao;
            NomeCliente = nomeCliente;
            CodigoSeguracao = codigoSeguracao;
            MesAnoValidade = mesAnoValidade;
            Parcelas = parcelas;
        }

        public bool Pagar()
        {
            return true;
        }

        public string NumeroCartao { get; private set; }

        public string NomeCliente { get; private set; }

        public string CodigoSeguracao { get; private set; }

        public string MesAnoValidade { get; private set; }

        public int Parcelas { get; private set; }
    }
}
