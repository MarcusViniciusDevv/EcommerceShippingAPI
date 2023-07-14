using EcommerceShippingDomain.Entidades.Produtos;
using EcommerceShippingRepository.MyContext;
using EcommerceShippingRepository.Produtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceShippingRepository.Implementação
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public ProdutosRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task AtualizarProdutoById(Guid id, decimal preco, string Nome, int Quantidade)
        {
            var product = await _repositoryContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            product.Preco = preco;
            product.Nome = Nome;
            product.Quantidade = Quantidade;    

            _repositoryContext.Update(product);
            await _repositoryContext.SaveChangesAsync();
        }

        public async Task DeletarProdutoById(Guid id)
        {
            // primeiro obtem qual é o produto 
            var product = await _repositoryContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            var delete =  _repositoryContext.Produtos.Remove(product);
            await _repositoryContext.SaveChangesAsync();
        }

        public async Task InserirProdutoAsync(Produto produto)
        {
            await _repositoryContext.Produtos.AddAsync(produto);

            await _repositoryContext.SaveChangesAsync();           
        }

        public async Task<List<Produto>> ListarProdutos()
        {
            var produtos = await _repositoryContext.Produtos.ToListAsync();
            return produtos;
        }
    }
}
