using BrewStore.Catalogo.Aplicacao.Dto;

namespace BrewStore.Catalogo.Aplicacao.Servico
{
    public interface IProdutoServico
    {
        Task<ProdutoDto> ObterPorId(int id);

        Task Adicionar(ProdutoDto produto);
    }
}
