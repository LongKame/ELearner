using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishLearningApp.DTO
{
    public class VocabInLessonDTO
    {
        public VocabInLessonDTO(int id, string lesson1, int partId, int levelId, string image, bool status)
        {
            Id = id;
            Lesson1 = lesson1;
            PartId = partId;
            LevelId = levelId;
            Image = image;
            Status = status;
        }

        public int Id { get; set; }
        public string Lesson1 { get; set; }
        public int PartId { get; set; }
        public int LevelId { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
