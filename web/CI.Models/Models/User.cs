using CI.Models.Models.ResolveModels;
using System.Collections.Generic;

namespace CI.Models.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string AvatarUrl { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }

        public ICollection<Task> UserTasks { get; set; }

        public ICollection<UserBoards> UserBoards { get; set; }
    }
}
