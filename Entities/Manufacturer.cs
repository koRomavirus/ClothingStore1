using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Entities
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }
       
        public ICollection<Product> Products { get; set; }
    }
}
