using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders;
using pizzaria_api.Model.Orders.DTOs;

namespace pizzaria_api.Repositorio
{
    public class RepOrder : IRepOrder
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void AddItem(Item item)
        {
            _context.Item.Add(item);
            _context.SaveChanges();
        }

        public void CreateOrder(CreateOrderDTO dto)
        {
            throw new NotImplementedException();
        }

        public Order DetailOrder(int order_id)
        {
            throw new NotImplementedException();
        }

        public List<Order> ListOrders()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int item_id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(int order_id)
        {
            throw new NotImplementedException();
        }

        public Order SendOrder(int order_id)
        {
            throw new NotImplementedException();
        }
    }
}
