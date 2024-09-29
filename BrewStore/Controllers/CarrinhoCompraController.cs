using BrewStore.Catalogo.Aplicacao.Servico;
using BrewStore.Dto.CarrinhoCompra;
using BrewStore.Vendas.Aplicacao.Comando;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BrewStore.Controllers
{
    [ApiController]
    [Route("v1/carrinho-compra")]
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoServico _produtoServico;

        private readonly IMediator _mediator; 

        public CarrinhoCompraController(IProdutoServico produtoServico, IMediator mediator)
        {
            _produtoServico = produtoServico;

            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(int idCliente, [FromBody] NovoProdutoDto novoProduto)
        {
            var produto = await _produtoServico.ObterPorId(novoProduto.Id);

            if (produto is null) return BadRequest();

            var adicionarPedidoItemComando = new AdicionarProdutoPedidoComando(idCliente, 
                produto.Id,
                produto.Valor,
                novoProduto.Quantidade,
                produto.QuantidadeMinimaDesconto,
                produto.ValorDescontoQuantidade,
                produto.DataDescontoSazonal,
                produto.PercentualDescontoSazonal);

            await _mediator.Send(adicionarPedidoItemComando);

            return Ok();
        }
    }
}
