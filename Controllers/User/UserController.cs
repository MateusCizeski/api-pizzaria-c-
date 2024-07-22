using Microsoft.AspNetCore.Mvc;
using pizzaria_api.Model.Users;
using pizzaria_api.Model.Users.DTOs;

namespace pizzaria_api.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    public class UserController : ControllerBase
    {
        private readonly IRepUser _repUser;

        public UserController(IRepUser repUser)
        {
            _repUser = repUser;
        }

        #region AuthUser
        [HttpPost]
        [Route("AuthUser")]
        public IActionResult AuthUser(AuthUserDTO dto)
        {
            var token = _repUser.AuthUser(dto);

            return Ok(token);
        }
        #endregion

        #region CreateUser
        [HttpPost]
        [Route("CreateUser")]
        public IActionResult CreateUser(CreateUserDTO dto)
        {
            var user = new User(dto);

            _repUser.CreateUser(user);

            return Ok();
        }
        #endregion

        #region DetailUser
        [HttpGet]
        [Route("DetailUser/{id}")]
        public IActionResult DetailUser([FromRoute] string id)
        {
            var user = _repUser.DetailUser(id);

            return Ok(user);
        }
        #endregion
    }
}
