using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        [Required]
        public string Category { get; set; }

        public string Shelf { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        public string Description { get; set; }
    }
}
