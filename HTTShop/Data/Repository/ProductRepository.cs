using HTTShop.Data.Interfaces;
using HTTShop.Models;
using Microsoft.EntityFrameworkCore;

namespace HTTShop.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include(c => c.Category).FirstOrDefault(p => p.Id == id);
        }

        public ICollection<Product> GetProducts()
        {
            return _context.Products.Include(c => c.Category).Where(p => p.available == true).ToList();
        }
    }
}