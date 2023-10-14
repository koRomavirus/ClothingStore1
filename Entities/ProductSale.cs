using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Entities
{
    public class ProductSale
    {
        [Key]
        public int SaleId { get; set; }
        public bool IsDeleted { get; set; }

        public Product Product { get; set; }
        public string ProductName { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
