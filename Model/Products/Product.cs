using pizzaria_api.Model.Products.DTOs;
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
        public string price { get; set; }
        public string description { get; set; }
        public string banner { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string category_id {  get; set; }

        public Product() { }

        public Product(CreateProductDTO dto)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = dto.name;
            this.price = dto.price;
            this.description = dto.description;
            this.category_id = dto.category_id;
            this.banner = dto.banner;
            this.created_at = DateTime.UtcNow;
            this.updated_at = DateTime.UtcNow;
        }
    }
}
