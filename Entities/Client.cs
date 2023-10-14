namespace ClothingStore.Entities
{
    public class Client
    {
        public int ClientId { get; set; }

        public bool IsDeleted { get; set; }
        public string LastName  { get; set; }
        public string NumberPhone { get; set; }

        public ICollection<ProductSale> Sales { get; set; } 
    }
}

