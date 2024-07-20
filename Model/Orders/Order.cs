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

        public Order(string id, int table, bool status, bool draft, string name, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.table = table;
            this.status = status;
            this.draft = draft;
            this.name = name;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }
    }
}
