using HTTShop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HTTShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var categories = _categoryRepository.GetCategories();
            return View(categories);
        }

        [HttpGet("Category/{id}")]
        public ViewResult Details(int id)
        {
            var categories = _categoryRepository.GetProductsByCategoryId(id);
            return View(categories);
        }
    }
}
