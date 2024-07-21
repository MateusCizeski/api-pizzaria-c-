using Microsoft.AspNetCore.Mvc;
using pizzaria_api.Model.Products;
using pizzaria_api.Model.Products.DTOs;

namespace pizzaria_api.Controllers
{
    [ApiController]
    [Route("api/v1/product")]
    public class ProductController : ControllerBase
    {
        private readonly IRepProduct _repProduct;

        public ProductController(IRepProduct repProduct)
        {
            _repProduct = repProduct;
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDTO dto)
        {
            var product = new Product(dto);
            _repProduct.CreateProduct(product);

            return Ok(product);
        }

        [HttpGet]
        [Route("ListByCategory/{id}")]
        public IActionResult ListByCategory([FromRoute] string id)
        {
            var findByCategory = _repProduct.ListProducts(id);

            return Ok(findByCategory);
        }
    }
}
