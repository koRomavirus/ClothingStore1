using ClothingStore.Data;
using ClothingStore.Entities;

namespace ClothingStore.Services
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly ApplicationDbContext _context;

        public ManufacturerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddManufacturer(Manufacturer newManufacturer)
        {
            _context.Manufac
        }

        public void DeleteManufacturer(int ManufacturerId)
        {
         
        }

        public void UpdateManufacturer(int ManufacturerId, Manufacturer newManufacturer)
        {
         
        }
    }
}
