﻿using pizzaria_api.Model.Users.DTOs;

namespace pizzaria_api.Model.Users
{
    public interface IRepUser
    {
        public string AuthUser(AuthUserDTO dto);
        public void CreateUser(User user);
        public object DetailUser(string id);
    }
}
