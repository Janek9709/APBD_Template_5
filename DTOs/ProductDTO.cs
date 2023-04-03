using System.ComponentModel.DataAnnotations;

namespace Zadanie5.DTOs
{
    public class ProductDTO
    {
        [Range(0, 10, ErrorMessage = "Amount must be in range 0 - 10")]
        public int Amount { get; set; }
    }
}
