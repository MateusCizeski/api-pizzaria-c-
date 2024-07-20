using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pizzaria_api.Model.Users
{
    [Table("users")]
    public class User
    {
        [Key]
        public string id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public User(string id, string name, string email, string password, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }
    }
}
