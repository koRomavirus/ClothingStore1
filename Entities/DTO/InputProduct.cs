using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Entities.DTO
{
    public class InputProduct
    {
        [Required]
        [StringLength(100, ErrorMessage = "Max limit{1}")]
        [Display(Name ="ProductName")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Max limit{1}")]
        [Display(Name = "Description")]
        public string Description{ get; set; }

        [StringLength(100, ErrorMessage = "Max limit{1}")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "ImgPath")]
        public string ImgPath{ get; set; }

        [Display(Name = "Provider Name")]
        public Provider Provider { get; set; }

        [Display(Name = "Manufacturer Name")]
        public Manufacturer Manufacturer { get; set; }
    }
}
