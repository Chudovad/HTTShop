using HTTShop.Data.Interfaces;
using HTTShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HTTShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();
            return View(products);
        }

        [HttpGet("Product/{id}")]
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}