using ClothingStore.Entities;

namespace ClothingStore.Services
{
    public interface IProductService
    {
        public void AddProduct(Product newProduct);
        public void DeleteProduct(int productId);
        public void UpdateProduct(int productId, Product newProduct);
        public Product GetProduct(string newProductName);
        public List<Product> GetAllProduct();



    }
}
