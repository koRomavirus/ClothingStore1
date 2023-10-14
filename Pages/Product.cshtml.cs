using ClothingStore.Data;
using ClothingStore.Entities;
using ClothingStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClothingStore.Pages
{
    public class ProductModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IProviderService _providerService;
        private readonly IManufacturerService _manufacturerService;

        public ProductModel(IProductService productService, IProviderService providerService, IManufacturerService manufacturerService)
        {
            _productService = productService;
            _providerService = providerService;
            _manufacturerService = manufacturerService;
        }

        [BindProperty]

        public IEnumerable<Product> ProductList { get; set; }

        public void OnGet()
        {
            ProductList = _productService.GetAllProduct();
        }
    }
}
