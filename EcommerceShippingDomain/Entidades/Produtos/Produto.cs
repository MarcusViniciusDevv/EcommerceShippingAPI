using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceShippingDomain.Entidades.Produtos
{
    public class Produto
    {
        public Guid Id { get; set; }

        public decimal Preco { get; set; }
               
        public string Nome { get; set; }
               
        public int Quantidade { get; set; }

    }
}

