using System;

namespace CI.Models.Models
{
    public class Tempo
    {
        public int Id { get; set; }

        public DateTime LogTime { get; set; }

        public DateTime EstimatedTime { get; set; }

        public DateTime ExpectedTime { get; set; }
    }
}
