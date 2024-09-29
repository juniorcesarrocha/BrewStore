using AutoMapper;
using BrewStore.Catalogo.Aplicacao.Dto;
using BrewStore.Catalogo.Dominio.Repositorio;
using BrewStore.Catalogo.Dominio;

namespace BrewStore.Catalogo.Aplicacao.Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        private readonly IMapper _mapper;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;

            _mapper = mapper;
        }

        public async Task<ProdutoDto> ObterPorId(int id)
        {
            return _mapper.Map<ProdutoDto>(await _produtoRepositorio.ObterPorId(id));
        }

        public async Task<IEnumerable<ProdutoDto>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ProdutoDto>>(await _produtoRepositorio.ObterTodos());
        }

        public async Task Adicionar(ProdutoDto produtoViewModel)
        {
            var produto = _mapper.Map<ProdutoDominio>(produtoViewModel);

            _produtoRepositorio.Adicionar(produto);

            await _produtoRepositorio.UnitOfWork.Commit();
        }

        public async Task Atualizar(ProdutoDto produtoViewModel)
        {
            var produto = _mapper.Map<ProdutoDominio>(produtoViewModel);

            _produtoRepositorio.Atualizar(produto);

            await _produtoRepositorio.UnitOfWork.Commit();
        }
    }
}
