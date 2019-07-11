using System.Collections.Generic;

namespace CI.Models.Models
{
    public class Column
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int TaskCount { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
