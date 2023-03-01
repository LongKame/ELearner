using System;
using System.Collections.Generic;

#nullable disable

namespace ELearner.Models
{
    public partial class SentenceStructure
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public int LessonId { get; set; }
        public string Sentence { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
