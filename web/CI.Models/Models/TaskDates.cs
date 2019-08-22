using System;

namespace CI.Models.Models
{
    public class TaskDates
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpdatedTime { get; set; }

        public DateTime ResolvedTime { get; set; }
    }
}
