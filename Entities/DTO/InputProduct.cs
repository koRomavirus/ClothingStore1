using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Entities.DTO
{
    public class InputProduct
    {
        [StringLength(100, ErrorMessage = "Max limit{1}")]
        [Display(Name ="ProductName")]
        public string ProductName { get; set; }

        [StringLength(500, ErrorMessage = "Max limit{1}")]
        [Display(Name = "Description")]
        public string Description{ get; set; }

        [StringLength(100, ErrorMessage = "Max limit{1}")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        
        [Display(Name = "ImgPath")]
        public string ImgPath{ get; set; }


    }
}
