using pizzaria_api.Model.Orders.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizzaria_api.Model.Orders
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public string id { get; set; }
        public int table { get; set; }
        public Boolean status { get; set; }
        public Boolean draft { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Order() { }

        public Order(CreateOrderDTO dto)
        {
            this.id = Guid.NewGuid().ToString();
            this.table = dto.table;
            this.status = false;
            this.draft = true;
            this.name = dto.name;
            this.created_at = DateTime.UtcNow;
            this.updated_at = DateTime.UtcNow;
        }
    }
}
