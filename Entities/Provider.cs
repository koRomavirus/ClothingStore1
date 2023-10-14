namespace ClothingStore.Entities
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public bool IsDeleted { get; set; }
        public string ProviderName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
