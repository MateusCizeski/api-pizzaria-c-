using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Xml.Linq;

namespace pizzaria_api.Model.Category
{
    [Table("categorys")]
    public class Category
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Category(string name)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = name;
            this.created_at = DateTime.UtcNow;
            this.updated_at = DateTime.UtcNow;
        }
    }
}
