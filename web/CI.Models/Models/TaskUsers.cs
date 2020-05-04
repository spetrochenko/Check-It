namespace CI.Models.Models
{
    public class TaskUsers
    {
        public int Id { get; set; }

        public User Assignee { get; set; }

        public User Reporter { get; set; }
    }
}
