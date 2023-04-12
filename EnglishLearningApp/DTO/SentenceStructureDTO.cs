using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishLearningApp.DTO
{
    public class SentenceStructureDTO
    {
        public int Id { get; set; }
        public string Lesson { get; set; }
        public int LessonId { get; set; }
        public string Sentence { get; set; }

        public SentenceStructureDTO(int id, string lesson, string sentence)
        {
            Id = id;
            Lesson = lesson;
            Sentence = sentence;
        }

        public SentenceStructureDTO(int id, string lesson, int lessonId, string sentence)
        {
            Id = id;
            Lesson = lesson;
            LessonId = lessonId;
            Sentence = sentence;
        }
    }
}
