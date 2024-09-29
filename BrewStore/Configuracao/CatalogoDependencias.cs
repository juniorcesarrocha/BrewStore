using BrewStore.Catalogo.Aplicacao.Servico;
using BrewStore.Catalogo.Dominio.Repositorio;
using BrewStore.Catalogo.Infraestrutura;
using BrewStore.Catalogo.Infraestrutura.Repositorio;

namespace BrewStore.Configuracao
{
    public static class CatalogoDependencias
    {
        public static void AdicionarCatalogoDependencias(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IProdutoServico, ProdutoServico>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
