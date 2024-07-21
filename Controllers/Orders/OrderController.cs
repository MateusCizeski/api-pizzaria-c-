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

        public OrderController(IRepOrder repOrder)
        {
            _repOrder = repOrder;
        }

        #region AddItem
        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(AddItemDTO dto)
        {
            var itemOrder = new Item(dto);
            _repOrder.AddItem(itemOrder);

            return Ok(itemOrder);
        }
        #endregion

        #region CreateOrder
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderDTO dto)
        {
            var order = new Order(dto);
            _repOrder.CreateOrder(order);

            return Ok(order);
        }
        #endregion

        #region DetailOrder
        [HttpGet]
        [Route("DetailOrder/{id}")]
        public IActionResult DetailOrder([FromRoute] string id)
        {
            var order = _repOrder.DetailOrder(id);

            return Ok(order);
        }
        #endregion

        #region FinishOrder
        [HttpPut]
        [Route("FinishOrder/{id}")]
        public IActionResult FinishOrder([FromRoute] string id)
        {
            var order = _repOrder.FinishOrder(id);

            return Ok(order);
        }
        #endregion

        #region ListOrders
        [HttpGet] 
        public IActionResult ListOrders()
        {
            var orders = _repOrder.ListOrders();

            return Ok(orders);
        }
        #endregion

        #region RemoverItem
        [HttpDelete]
        [Route("RemoverItem/{id}")]
        public IActionResult RemoverItem([FromRoute] string id)
        {
            _repOrder.RemoveItem(id);

            return Ok();
        }
        #endregion

        #region RemoverOrder
        [HttpDelete]
        [Route("RemoverOrder/{id}")]
        public IActionResult RemoverOrder([FromRoute] string id)
        {
            _repOrder.RemoveOrder(id);

            return Ok();
        }
        #endregion

        #region SendOrder
        [HttpPut]
        [Route("SendOrder/{id}")]
        public IActionResult SendOrder([FromRoute] string id)
        {
            var order = _repOrder.SendOrder(id);

            return Ok(order);
        }
        #endregion
    }
}
