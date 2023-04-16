using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishLearningApp.DTO
{
    public class PassLevelDTO
    {
        public PassLevelDTO(string lesson, string level, bool? status)
        {
            Lesson = lesson;
            Level = level;
            Status = status;
        }

        public string Lesson { get; set; }
        public string Level { get; set; }
        public bool? Status { get; set; }

    }
}
