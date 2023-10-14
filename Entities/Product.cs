using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Entities
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        public bool IsDeleted { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price  { get; set; }
        public string ImgPath { get; set; }

        public Provider Provider { get; set; }
        public int ProviderId { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }

        public ICollection<ProductSale> ProductSales { get; set; }
    }
}
