using pizzaria_api.Model.Orders.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizzaria_api.Model.Items
{
    [Table("items")]
    public class Item
    {
        [Key]
        public string id { get; set; }
        public int amount { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string order_id { get; set; }
        public string product_id { get; set; }
       
        public Item(AddItemDTO dto)
        {
            this.id = Guid.NewGuid().ToString();
            this.amount = dto.amount;
            this.order_id = dto.order_id;
            this.product_id = dto.product_id;
            this.created_at = DateTime.UtcNow;
            this.updated_at = DateTime.UtcNow;
        }
    }
}
