using Microsoft.AspNetCore.Mvc;
using CoffeeShop27.Models.Interfaces;
namespace CoffeeShop27.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Shop()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }
        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);

            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }
    }
}
