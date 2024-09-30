using AutoMapper;
using BrewStore.Catalogo.Aplicacao.Dto;
using BrewStore.Catalogo.Dominio;

namespace BrewStore.Catalogo.Aplicacao.Mapeamento
{
    public class CatalogoAplicacaoMapper : Profile
    {
        public CatalogoAplicacaoMapper()
        {
            CreateMap<ProdutoDominio, ProdutoViewModel>(MemberList.None).ReverseMap();
        }
    }
}
