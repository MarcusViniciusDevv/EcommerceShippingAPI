using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceShippingAPI.Models
{
    public class AtualizarProdutoModel
    {
        [Required]
        public Guid Id { get; set; }

        public decimal Preco { get; set; }
       
        public string Nome { get; set; }
        
        public int Quantidade { get; set; }

    }
}
