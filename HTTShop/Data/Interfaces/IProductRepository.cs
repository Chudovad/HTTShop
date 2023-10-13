using HTTShop.Models;

namespace HTTShop.Data.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetProducts();
        Product GetProductById(int id);
    }
}
