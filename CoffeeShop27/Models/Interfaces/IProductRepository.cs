using CoffeeShop27.Models;
using CoffeeShop27.Models.Interfaces;
namespace CoffeeShop27.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product GetProductDetail(int id);
    }
}
