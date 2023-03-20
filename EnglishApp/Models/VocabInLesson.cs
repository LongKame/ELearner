using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishApp.Models
{
    public partial class VocabInLesson
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public string Image { get; set; }
        public string Word { get; set; }
        public string Pronunciation { get; set; }
        public string Meaning { get; set; }
        public string Synonymous { get; set; }
        public string Antonymous { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
