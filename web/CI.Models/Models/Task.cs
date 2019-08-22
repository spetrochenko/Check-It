using CI.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CI.Models.Models
{
    public class Task
    {
        [Key]
        public string TaskKey { get; set; }

        public TaskType Type { get; set; }

        public TaskStatus Status { get; set; }

        public TaskDates Dates { get; set; }

        public TaskUsers Users { get; set; }

        public Tempo Tempo { get; set; }

        public string Description { get; set; }

        public TaskPriority Priority { get; set; }

        public ICollection<TaskLabel> Labels { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Attachment> Attachments { get; set; }
    }
}
