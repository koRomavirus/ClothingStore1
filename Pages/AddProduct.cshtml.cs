using ClothingStore.Entities;
using ClothingStore.Entities.DTO;
using ClothingStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClothingStore.Pages
{
    public class AddProductModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IProviderService _providerService;
        private readonly IManufacturerService _manufacturerService;

        public AddProductModel (IProductService productService, IProviderService providerService, IManufacturerService manufacturerService)
        {
            _productService = productService;
            _providerService = providerService;
            _manufacturerService = manufacturerService;
        }

        [BindProperty]
        public InputProduct InputProduct { get; set; }

       

        public void OnGet()
        {
           
        }

        [HttpPost]
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var product = new Product()
            {
                  ProductName =InputProduct.ProductName,
                  Description=InputProduct.Description,
                  Category =InputProduct.Category,
                  Price = InputProduct.Price,
            };


            _productService.AddProduct(product);


            return RedirectToPage("Product");


        }
    }
}
