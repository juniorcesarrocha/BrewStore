using BrewStore.Vendas.Dominio.Infraestrutura.Repositorio;
using BrewStore.Vendas.Infraestrutura;
using BrewStore.Vendas.Infraestrutura.Repositorio;

namespace BrewStore.Configuracao
{
    public static class VendasDependencias
    {
        public static void AdicionarVendasDependencias(this IServiceCollection services)
        {
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
            services.AddScoped<VendasContext>();
        }
    }
}
