using BrewStore.Catalogo.Dominio;
using BrewStore.Catalogo.Dominio.Repositorio;
using BrewStore.Core.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BrewStore.Catalogo.Infraestrutura.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly CatalogoContext _context;

        public ProdutoRepositorio(CatalogoContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<ProdutoDominio>> ObterTodos()
            => await _context.Produtos.AsNoTracking().ToListAsync();

        public async Task<ProdutoDominio> ObterPorId(int id)
        { 
            return await _context.Produtos.FindAsync(id);
        } 
        
        public void Adicionar(ProdutoDominio produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Atualizar(ProdutoDominio produto)
        {
            _context.Produtos.Update(produto);
        }
    }
}
