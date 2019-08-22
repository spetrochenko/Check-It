using System;

namespace CI.Models.Models
{
    public class Attachment
    {
        public int Id { get; set; }

        public string PhotoUrl { get; set; }

        public string DocumentUrl { get; set; }

        public string AudioUrl { get; set; }

        public DateTime TimeAttached { get; set; }

        public User AttachBy { get; set; }
    }
}
