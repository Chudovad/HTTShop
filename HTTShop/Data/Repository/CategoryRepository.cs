using HTTShop.Data.Interfaces;
using HTTShop.Models;
using Microsoft.EntityFrameworkCore;

namespace HTTShop.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public ICollection<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Include(c => c.Category).Where(c => c.CategoryId == categoryId).ToList();
        }
    }
}
