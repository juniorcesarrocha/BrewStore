using BrewStore.Core.Infraestrutura.Repositorio;
using BrewStore.Vendas.Dominio;
using Microsoft.EntityFrameworkCore;

namespace BrewStore.Vendas.Infraestrutura
{
    public class VendasContext : DbContext, IUnitOfWork
    {
        public VendasContext(DbContextOptions<VendasContext> options)
            : base(options) { }

        public DbSet<PedidoDominio> Pedidos { get; set; }

        public DbSet<PedidoItemDominio> PedidoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VendasContext).Assembly);
        }

        public async Task<bool> Commit()
            => await base.SaveChangesAsync() > 0;
    }
}
