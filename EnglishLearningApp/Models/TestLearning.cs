using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishLearningApp.Models
{
    public partial class TestLearning
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string Correct { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
