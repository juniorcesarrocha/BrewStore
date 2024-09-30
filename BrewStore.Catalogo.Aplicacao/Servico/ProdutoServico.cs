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

        public async Task<ProdutoViewModel> ObterPorId(int id)
        {
            return _mapper.Map<ProdutoViewModel>(await _produtoRepositorio.ObterPorId(id));
        }

        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepositorio.ObterTodos());
        }

        public async Task Adicionar(ProdutoViewModel produtoViewModel)
        {
            var produto = _mapper.Map<ProdutoDominio>(produtoViewModel);

            _produtoRepositorio.Adicionar(produto);

            await _produtoRepositorio.UnitOfWork.Commit();
        }

        public async Task Atualizar(ProdutoViewModel produtoViewModel)
        {
            var produto = _mapper.Map<ProdutoDominio>(produtoViewModel);

            _produtoRepositorio.Atualizar(produto);

            await _produtoRepositorio.UnitOfWork.Commit();
        }
    }
}
