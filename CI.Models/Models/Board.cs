using CI.Models.Models.ResolveModels;
using System;
using System.Collections.Generic;

namespace CI.Models.Models
{
    public class Board
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AvatarUrl { get; set; }

        public ICollection<Column> Columns { get; set; }

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedBy { get; set; }

        public User Owner { get; set; }

        public ICollection<UserBoards> Users { get; set; }
    }
}
