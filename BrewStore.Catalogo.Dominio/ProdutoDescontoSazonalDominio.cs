namespace BrewStore.Catalogo.Dominio
{
    public class ProdutoDescontoSazonalDominio
    {
        public ProdutoDescontoSazonalDominio()
        {
            
        }

        public ProdutoDescontoSazonalDominio(DateTime? data, decimal? percentual)
        {
            Data = data;

            Percentual = percentual;
        }

        public DateTime? Data { get; private set; }

        public decimal? Percentual { get; private set; }
    }
}
