namespace BrewStore.Catalogo.Aplicacao.Dto
{
    public record ProdutoViewModel(int Id,
            string Nome,
            string Descricao,
            decimal Valor,
            int QuantidadeEstoque,
            bool Disponivel,
            int? QuantidadeMinimaDesconto,
            decimal? ValorDescontoQuantidade,
            DateTime? DataDescontoSazonal,
            decimal? PercentualDescontoSazonal);
}
