using pizzaria_api.Model.Users.DTOs;
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

        public User() { }
        public User(CreateUserDTO dto)
        {
            this.id = Guid.NewGuid().ToString();
            this.name = dto.name;
            this.email = dto.email;
            this.password = dto.password;
            this.created_at = DateTime.UtcNow;
            this.updated_at = DateTime.UtcNow;
        }
    }
}
