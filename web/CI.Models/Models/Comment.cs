﻿using System;

namespace CI.Models.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime Time { get; set; }

        public User User { get; set; }
    }
}
