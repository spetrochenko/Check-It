using CI.Api.ViewModels;
using CI.Bussiness.Services.Interfaces;
using CI.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace CI.Api.Controllers
{
    [Route("api/UserController")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("CreateUser")]
        public CreateUserViewModel CreateUser([FromBody]CreateUserViewModel createUserViewModel)
        {
            if (createUserViewModel == null)
            {
                return null;
            }

            userService.CreateUser(new User
            {
                FirstName = createUserViewModel.FirstName,
                LastName = createUserViewModel.LastName
            });

            return createUserViewModel;
        }

        [HttpGet("Test")]
        public string Test()
        {
            return "Test";
        }
    }
}
