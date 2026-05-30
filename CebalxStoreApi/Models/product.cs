using System.ComponentModel.DataAnnotations;

namespace CebalxStoreApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        // حارس الأمن الأول
        [Required(ErrorMessage = "Product name is required!")]
        public string Name { get; set; }

        // حارس الأمن الثاني
        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000!")]
        public decimal Price { get; set; }
    }
}