using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishLearningApp.Models
{
    public partial class PassLevel
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? LessonId { get; set; }
        public bool? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
