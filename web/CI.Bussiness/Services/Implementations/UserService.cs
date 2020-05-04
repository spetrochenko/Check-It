using CI.Bussiness.Services.Interfaces;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;
using System;

namespace CI.Bussiness.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> repository;

        public UserService(IGenericRepository<User> repository)
        {
            this.repository = repository;
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
