using HTTShop.Data;
using HTTShop.Models;

namespace HTTShop
{
    public class Seed
    {
        private readonly ApplicationDbContext _context;
        public Seed(ApplicationDbContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            if (!_context.Products.Any())
            {
                var products = new List<Product>()
                {
                    new Product
                    {
                        Name = "ProductName1",
                        Description = "ProductDescription1",
                        Price = 100,
                        available = true,
                        Category = new Category()
                        {
                            Name = "CategoryName1",
                            Description = "CategoryDescription1"
                        }
                    },
                    new Product
                    {
                        Name = "ProductName2",
                        Description = "ProductDescription2",
                        Price = 150,
                        available = true,
                        Category = new Category()
                        {
                            Name = "CategoryName2",
                            Description = "CategoryDescription2"
                        }
                    },
                    new Product
                    {
                        Name = "ProductName3",
                        Description = "ProductDescription3",
                        Price = 150,
                        available = false,
                        Category = new Category()
                        {
                            Name = "CategoryName3",
                            Description = "CategoryDescription3"
                        }
                    },
                    new Product
                    {
                        Name = "ProductName4",
                        Description = "ProductDescription4",
                        Price = 300,
                        available = true,
                        Category = new Category()
                        {
                            Name = "CategoryName4",
                            Description = "CategoryDescription4"
                        }
                    },
                    new Product
                    {
                        Name = "ProductName5",
                        Description = "ProductDescription5",
                        Price = 1000,
                        available = true,
                        CategoryId = 1,
                    }
                };
                _context.Products.AddRange(products);
                _context.SaveChanges();
            }
        }
    }
}