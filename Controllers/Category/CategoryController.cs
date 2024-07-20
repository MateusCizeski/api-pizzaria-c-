using Microsoft.AspNetCore.Mvc;
using pizzaria_api.Model.Category;

namespace pizzaria_api.Controllers
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryController : ControllerBase
    {
        private readonly IRepCategory _repCategory;

        public CategoryController(IRepCategory repCategory)
        {
            _repCategory = repCategory;
        }

        [HttpPost]
        public IActionResult CreateCategory(string name)
        {
            var category = new Category(name);
            _repCategory.CreateCategory(category);

            return Ok(category);
        }

        [HttpGet]
        public IActionResult ListCategorys()
        {
            var categorys = _repCategory.ListCategorys();

            return Ok(categorys);
        }
    }
}
