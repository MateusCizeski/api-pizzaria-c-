using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizzaria_api.Model.Products
{
    [Table("products")]
    public class Product
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public Decimal price { get; set; }
        public string description { get; set; }
        public string banner { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string category_id {  get; set; }
        
        public Product(string id, string name, decimal price, string description, string banner, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.banner = banner;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }
    }
}
