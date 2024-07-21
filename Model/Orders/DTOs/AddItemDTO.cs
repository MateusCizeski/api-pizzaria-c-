namespace pizzaria_api.Model.Orders.DTOs
{
    public class AddItemDTO
    {
        public int amount { get; set; }
        public string order_id { get; set; }
        public string product_id { get; set; }
    }
}
