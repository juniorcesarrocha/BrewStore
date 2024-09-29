using BrewStore.Catalogo.Infraestrutura;
using BrewStore.Vendas.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BrewStore.Configuracao
{
    public static class ConfiguracaoAplicacao
    {
        public static void ConfigurarDependencias(WebApplicationBuilder webApplicationBuilder)
        {
            var services = webApplicationBuilder.Services;

            services.AddDbContext<CatalogoContext>(options =>
                options.UseSqlite(webApplicationBuilder.Configuration.GetConnectionString("CatalogoDataBase")));

            services.AddDbContext<VendasContext>(options =>
                options.UseSqlite(webApplicationBuilder.Configuration.GetConnectionString("VendasDataBase")));

            services.ConfigurarAutoMapper();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AdicionarCatalogoDependencias();
            services.AdicionarVendasDependencias();

        }
    }
}
