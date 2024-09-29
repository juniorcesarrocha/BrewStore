using BrewStore.Catalogo.Dominio;
using System.Runtime.CompilerServices;

namespace BrewStore.Catalogo.Aplicacao.Dto
{
    public class ProdutoDto
    {
        public ProdutoDto()
        {
            
        }

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
    }
}
