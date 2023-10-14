namespace ClothingStore.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public bool IsDeleted { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<ProductSale> ProductSales { get; set; }

    }
}
