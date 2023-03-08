using System;
using System.Collections.Generic;

#nullable disable

namespace LearningApp.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            Questions = new HashSet<Question>();
            SentenceStructures = new HashSet<SentenceStructure>();
            TestLearnings = new HashSet<TestLearning>();
            VocabInLessons = new HashSet<VocabInLesson>();
        }

        public int Id { get; set; }
        public string Lesson1 { get; set; }
        public int PartId { get; set; }
        public int LevelId { get; set; }
        public string Image { get; set; }

        public virtual Level Level { get; set; }
        public virtual Part Part { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<SentenceStructure> SentenceStructures { get; set; }
        public virtual ICollection<TestLearning> TestLearnings { get; set; }
        public virtual ICollection<VocabInLesson> VocabInLessons { get; set; }
    }
}
