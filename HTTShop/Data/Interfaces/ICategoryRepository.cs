using HTTShop.Models;

namespace HTTShop.Data.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        ICollection<Product> GetProductsByCategoryId(int categoryId);
    }
}
