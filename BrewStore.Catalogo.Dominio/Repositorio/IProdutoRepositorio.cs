using BrewStore.Core.Infraestrutura.Repositorio;

namespace BrewStore.Catalogo.Dominio.Repositorio
{
    public interface IProdutoRepositorio : IRepositorio<ProdutoDominio>
    {
        Task<IEnumerable<ProdutoDominio>> ObterTodos();
        Task<ProdutoDominio> ObterPorId(int id);

        void Adicionar(ProdutoDominio produto);
        void Atualizar(ProdutoDominio produto);
    }
}
