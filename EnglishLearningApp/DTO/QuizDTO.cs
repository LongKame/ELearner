using EnglishLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishLearningApp.DTO
{
    public class QuizDTO
    {
        public int Id { get; set; }
        public string Lesson { get; set; }
        public string Question { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public QuizDTO(int id, string lesson, string question, ICollection<Answer> answers)
        {
            Id = id;
            Lesson = lesson;
            Question = question;
            Answers = answers;
        }
    }
}
