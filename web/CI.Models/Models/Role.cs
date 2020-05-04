using CI.Models.Models.ResolveModels;
using System.Collections.Generic;

namespace CI.Models.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
