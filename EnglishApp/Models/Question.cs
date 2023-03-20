using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishApp.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public int LessonId { get; set; }
        public string Question1 { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
