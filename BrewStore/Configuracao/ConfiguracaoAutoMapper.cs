using BrewStore.Catalogo.Aplicacao.Mapeamento;

namespace BrewStore.Configuracao
{
    public static class ConfiguracaoAutoMapper
    {
        public static IServiceCollection ConfigurarAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CatalogoAplicacaoMapper));

            return services;
        }
    }
}
