using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders.DTOs;

namespace pizzaria_api.Model.Orders
{
    public interface IRepOrder
    {
        public void AddItem(Item item);
        public void CreateOrder(Order order);
        public Order DetailOrder(string order_id);
        public Order FinishOrder(string order_id);
        public List<Order> ListOrders();
        public void RemoveItem(string item_id);
        public void RemoveOrder(string order_id);
        public Order SendOrder(string order_id);
    }
}
