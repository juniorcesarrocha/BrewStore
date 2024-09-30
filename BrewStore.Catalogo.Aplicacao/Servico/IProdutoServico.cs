using BrewStore.Catalogo.Aplicacao.Dto;

namespace BrewStore.Catalogo.Aplicacao.Servico
{
    public interface IProdutoServico
    {
        Task<ProdutoViewModel> ObterPorId(int id);

        Task Adicionar(ProdutoViewModel produto);
    }
}
