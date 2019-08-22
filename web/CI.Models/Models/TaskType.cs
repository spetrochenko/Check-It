using CI.Models.Enums;

namespace CI.Models.Models
{
    public class TaskType
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ColorTask Color { get; set; }
    }
}
