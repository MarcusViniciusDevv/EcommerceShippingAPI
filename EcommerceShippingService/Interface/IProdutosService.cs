using EcommerceShippingDomain.Entidades.Produtos;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace EcommerceShippingService.Interface
{
    public interface IProdutosService
    {
        Task InserirProduto (Produto produto);

        Task<List<Produto>> ListarProdutos ();

        Task DeletarProdutoById(Guid id);

        Task AtualizarProdutoById(Guid id,decimal preco, string Nome, int Quantidade);
        
    }
}
