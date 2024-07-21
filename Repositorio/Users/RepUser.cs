using pizzaria_api.Model.Users;
using pizzaria_api.Model.Users.DTOs;

namespace pizzaria_api.Repositorio
{
    public class RepUser : IRepUser
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        #region AuthUser
        public User AuthUser(AuthUserDTO dto)
        {
            throw new NotImplementedException();
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
