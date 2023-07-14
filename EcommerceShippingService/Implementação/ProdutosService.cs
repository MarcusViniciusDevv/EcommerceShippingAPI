using EcommerceShippingDomain.Entidades.Produtos;
using EcommerceShippingRepository.Produtos;
using EcommerceShippingService.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceShippingService.Implementação
{
    public class ProdutosService : IProdutosService
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutosService(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }       

        public Task AtualizarProdutoById(Guid id, decimal preco, string Nome, int Quantidade)
        {
            var product =  _produtosRepository.AtualizarProdutoById(id, preco, Nome, Quantidade);
            return product;

        }

        public async Task DeletarProdutoById(Guid id)
        {
           await _produtosRepository.DeletarProdutoById(id);  
            
        }

        public async Task InserirProduto(Produto produto)
        {
            await _produtosRepository.InserirProdutoAsync(produto);          
        }

        public async Task<List<Produto>> ListarProdutos()
        {
            var produtos = await _produtosRepository.ListarProdutos();
            return produtos;
        }

    }
}
