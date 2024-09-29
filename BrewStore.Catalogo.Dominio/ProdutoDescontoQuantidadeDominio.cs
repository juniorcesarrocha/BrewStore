namespace BrewStore.Catalogo.Dominio
{
    public class ProdutoDescontoQuantidadeDominio
    {
        public ProdutoDescontoQuantidadeDominio()
        {
            
        }

        public ProdutoDescontoQuantidadeDominio(int? quantidadeMinima, decimal? valor)
        {
            QuantidadeMinima = quantidadeMinima;

            Valor = valor;
        }

        public int? QuantidadeMinima { get; private set; }

        public decimal? Valor { get; private set; }
    }
}
