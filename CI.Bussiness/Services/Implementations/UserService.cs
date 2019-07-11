using CI.Bussiness.Services.Interfaces;
using CI.Data.Repositories.Interfaces;
using CI.Models.Models;

namespace CI.Bussiness.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            userRepository.Create(user);
        }
    }
}
