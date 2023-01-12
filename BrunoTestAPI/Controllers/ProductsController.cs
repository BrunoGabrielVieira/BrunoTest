using BrunoTestAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrunoTestAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private static readonly Product[] _products = new[]
        {
            new Product
            {
                Id = 0,
                Name = "Product 1",
                Description = "Description 1",
                Price = 100.00M
            },
            new Product
            {
                Id = 1,
                Name = "Product 2",
                Description = "Description 2",
                Price = 275.25M
            },
            new Product
            {
                Id = 2,
                Name = "Product 3",
                Description = "Description 3",
                Price = 190.50M
            }
        };

        [HttpGet]
        public Product[] Get()
        {
            return _products;
        }
    }
}
