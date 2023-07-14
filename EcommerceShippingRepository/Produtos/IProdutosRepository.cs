using EcommerceShippingDomain.Entidades.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceShippingRepository.Produtos
{
    public interface IProdutosRepository
    {        
        Task InserirProdutoAsync(Produto produto);
        Task<List<Produto>> ListarProdutos();
        Task DeletarProdutoById(Guid id);
        Task AtualizarProdutoById(Guid id, decimal preco, string Nome, int Quantidade);
        
    }
}
