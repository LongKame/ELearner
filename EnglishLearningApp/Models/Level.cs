using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishLearningApp.Models
{
    public partial class Level
    {
        public Level()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public string Level1 { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
