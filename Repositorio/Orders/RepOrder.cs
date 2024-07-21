using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders;
using pizzaria_api.Model.Orders.DTOs;

namespace pizzaria_api.Repositorio
{
    public class RepOrder : IRepOrder
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        #region AddItem
        public void AddItem(Item item)
        {
            _context.Item.Add(item);
            _context.SaveChanges();
        }
        #endregion

        #region CreateOrder
        public void CreateOrder(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
        }
        #endregion

        #region DetailOrder
        public Order DetailOrder(string order_id)
        {
            var orderDetail = _context.Order.Where(p => p.id == order_id).FirstOrDefault();

            if(orderDetail == null)
            {
                new Exception("Ordem não encontrada");
                return null;
            }

            return orderDetail;
        }
        #endregion

        #region FinishOrder
        public Order FinishOrder(string order_id)
        {
            var order = _context.Order.Where(p => p.id == order_id).FirstOrDefault();
            order.status = true;

            _context.SaveChanges();
            return order;
        }
        #endregion

        #region ListOrders
        public List<Order> ListOrders()
        {
            var orders = _context.Order.ToList();

            return orders;
        }
        #endregion

        #region RemoveItem
        public void RemoveItem(string item_id)
        {
            var item = _context.Item.Where(p => p.id == item_id).FirstOrDefault();
                
            if(item == null)
            {
                new Exception("Item não encontrado");
            }

            _context.Item.Remove(item);
            _context.SaveChanges();
        }
        #endregion

        #region RemoveOrder
        public void RemoveOrder(string order_id)
        {
            var order = _context.Order.Where(p => p.id == order_id).FirstOrDefault();

            if (order == null) 
            {
                new Exception("Ordem não encontrada");
            }

            _context.Order.Remove(order);
            _context.SaveChanges();
        }
        #endregion

        #region SendOrder
        public Order SendOrder(string order_id)
        {
            var order = _context.Order.Where(p => p.id == order_id).FirstOrDefault();
            order.draft = false;

            _context.SaveChanges();
            return order;
        }
        #endregion
    }
}
