using BrewStore.Catalogo.Dominio;
using BrewStore.Core.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BrewStore.Catalogo.Infraestrutura
{
    public class CatalogoContext : DbContext, IUnitOfWork
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options)
            : base(options) { }

        public DbSet<ProdutoDominio> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogoContext).Assembly);
        }

        public async Task<bool> Commit()
            =>await base.SaveChangesAsync() > 0;
    }
}
