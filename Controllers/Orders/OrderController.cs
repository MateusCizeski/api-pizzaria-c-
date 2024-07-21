using Microsoft.AspNetCore.Mvc;
using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders;
using pizzaria_api.Model.Orders.DTOs;

namespace pizzaria_api.Controllers
{
    [ApiController]
    [Route("api/v1/order")]
    public class OrderController : ControllerBase
    {
        private readonly IRepOrder _repOrder;

        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(AddItemDTO dto)
        {
            var itemOrder = new Item(dto);
            _repOrder.AddItem(itemOrder);

            return Ok(itemOrder);
        }

        [HttpGet] 
        public IActionResult ListOrders()
        {
            var orders = _repOrder.ListOrders();

            return Ok(orders);
        }
    }
}
