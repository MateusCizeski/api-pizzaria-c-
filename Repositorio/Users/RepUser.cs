using pizzaria_api.Model.Users;
using pizzaria_api.Model.Users.DTOs;
using pizzaria_api.Services;

namespace pizzaria_api.Repositorio
{
    public class RepUser : IRepUser
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        #region AuthUser
        public string AuthUser(AuthUserDTO dto)
        {
            var user = _context.User.Where(p => p.email == dto.email).FirstOrDefault();

            if (user == null)
            {
                throw new Exception("Email/Senha incorretos");
            }

            var token = TokenService.GenerateToken(user);

            return token;
        }
        #endregion

        #region CreateUser
        public void CreateUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }
        #endregion

        #region DetailUser
        public object DetailUser(string id)
        {
            var user = _context.User
                        .Where(p => p.id == id)
                        .Select(p => new
                        {
                            p.id,
                            p.name,
                            p.email,
                        }).FirstOrDefault();

        return user;
        }
        #endregion
    }
}
