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
       
        public Item(string id, int amount, DateTime created_at, DateTime updated_at, string order_id, string product_id)
        {
            this.id = id;
            this.amount = amount;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.order_id = order_id;
            this.product_id = product_id;
        }
    }
}
