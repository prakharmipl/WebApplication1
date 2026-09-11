using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{


    [ApiController]
    [Route("[controller]/[Action]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        

        public ProductModel UpdateProduct(ProductModel model)
        {



            var products = _productRepository.GetProductById(model.Id);







            return products;
        }

        [HttpPost]
        public IActionResult AddProduct(string name)
        {
            _productRepository.addProduct(name);

            var products = _productRepository.GetProducts();
            return Ok(products);
        }

    }
}
