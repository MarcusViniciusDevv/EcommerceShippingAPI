using EcommerceShippingAPI.Models;
using EcommerceShippingDomain.Entidades.Produtos;
using EcommerceShippingService.Implementação;
using EcommerceShippingService.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EcommerceShippingAPI.Controllers
{
    [Route("Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProdutosService _produtosService;

        public ProductController(IProdutosService produtosService)
        {
            _produtosService = produtosService;
        }

        [HttpPost("InserirProduto")]
        public async Task<IActionResult> InserirProdutoAsync([FromBody] AdicionarProdutoModel model)
        {
            if (model.Nome == null)
            {
                return BadRequest("Nome do produto é obrigatório");
            }
            if (model.Preco == 0)
            {
                return BadRequest("Preço do produto não pode ser 0,00");
            }

            var produto = new Produto();
            produto.Nome = model.Nome;
            produto.Preco = model.Preco;
            produto.Quantidade = model.Quantidade;

            await _produtosService.InserirProduto(produto);

            return Ok();
        }

        [HttpGet("ListarProdutos")]
        public async Task<IActionResult> ListarProdutosAsync()
        {
            var produtos = await _produtosService.ListarProdutos();
            return Ok(produtos);
        }

        [HttpDelete("DeletarProduto{id}")]
        public async Task<IActionResult> DeletarProdutoAsync(Guid id)
        {
            await _produtosService.DeletarProdutoById(id);
            return Ok();
        }
        [HttpPut("AtualizarProduto")]
        public async Task<IActionResult> AtualizarProdutoAsync([FromBody] AtualizarProdutoModel model)
        {
            await _produtosService.AtualizarProdutoById(model.Id,model.Preco,model.Nome,model.Quantidade);
            return Ok();
        }

    }   
}
