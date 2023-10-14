using ClothingStore.Data;
using ClothingStore.Entities;

namespace ClothingStore.Services
{
    public class ProductService : IProductService
    {
            
        private readonly ApplicationDbContext _context;
        public void AddProduct(Product newProduct)
        {
           _context.Products.Add(newProduct);
            _context.SaveChanges();
        }
        
        public void DeleteProduct(int productId)
        {
            var product = _context.Products
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();
            product.IsDeleted = true;
            _context.SaveChanges();
                
        }

        public Product GetProduct(string newProductName)
        {
            return _context.Products
                .Where(product => product.ProductName == newProductName && product.IsDeleted == false)
                .FirstOrDefault();
        }

        public void UpdateProduct(int productId, Product newProduct)
        {
            var products = _context.Products
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();
            products.IsDeleted = true;

            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public List<Product> GetAllProduct() {
            return _context.Products
                .Where( product => product.IsDeleted == false)
                .ToList();
        }

    }
}
