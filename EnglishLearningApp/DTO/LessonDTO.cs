using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishLearningApp.DTO
{
    public class LessonDTO
    {
        public LessonDTO(int id, string lesson1, string part, string level, string image, bool? status)
        {
            Id = id;
            Lesson1 = lesson1;
            Part = part;
            Level = level;
            Image = image;
            Status = status;
        }

        public LessonDTO(int id, string lesson1, string part, string level, string image)
        {
            Id = id;
            Lesson1 = lesson1;
            Part = part;
            Level = level;
            Image = image;
        }

        public int Id { get; set; }
        public string Lesson1 { get; set; }
        public string Part { get; set; }
        public string Level { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }


    }
}
