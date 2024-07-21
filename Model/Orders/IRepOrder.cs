using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders.DTOs;

namespace pizzaria_api.Model.Orders
{
    public interface IRepOrder
    {
        public void AddItem(Item item);
        public void CreateOrder(CreateOrderDTO dto);
        public Order DetailOrder(int order_id);
        public List<Order> ListOrders();
        public void RemoveItem(int item_id);
        public void RemoveOrder(int order_id);
        public Order SendOrder(int order_id);
    }
}
