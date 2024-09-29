namespace BrewStore.Catalogo.Dominio
{
    public class ProdutoDominio
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public decimal Valor { get; private set; }

        public int QuantidadeEstoque { get; private set; }

        public bool Disponivel { get; private set; }

        public int? QuantidadeMinimaDesconto { get; private set; }

        public decimal? ValorDescontoQuantidade { get; private set; }

        public DateTime? DataDescontoSazonal { get; private set; }

        public decimal? PercentualDescontoSazonal { get; private set; }

        public ProdutoDominio() 
        {
            
        }

        public ProdutoDominio(string nome, string descricao, decimal valor, int quantidadeEstoque, bool disponivel)
        {
            Nome = nome;

            Descricao = descricao;

            Valor = valor;

            QuantidadeEstoque = quantidadeEstoque;

            Disponivel = disponivel;

        }


        public void AdicionarEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }

        public void AdicionarDescontoPorQuantidadeMinimaCompra(int quantidadeMinimaDesconto, decimal valorDescontoQuantidade)
        {
            QuantidadeMinimaDesconto = quantidadeMinimaDesconto;

            ValorDescontoQuantidade = valorDescontoQuantidade;
        }

        public void AdicionarDescontoPorSazonalidadeCompra(DateTime dataDescontoSazonal, decimal percentualDescontoSazonal)
        {
            DataDescontoSazonal = dataDescontoSazonal;

            PercentualDescontoSazonal = percentualDescontoSazonal;
        }
    }
}
