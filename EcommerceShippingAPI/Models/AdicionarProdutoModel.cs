using System.ComponentModel.DataAnnotations;

namespace EcommerceShippingAPI.Models
{

    public class AdicionarProdutoModel        
    {
        [Required]
        
        public decimal Preco { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public  int Quantidade { get; set; }

    }
}
