using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishLearningApp.DTO
{
    public class VocabDTO
    {
        public int Id { get; set; }
        public string Lesson { get; set; }
        public string Image { get; set; }
        public string Word { get; set; }
        public string Pronunciation { get; set; }
        public string Meaning { get; set; }
        public string Synonymous { get; set; }
        public string Antonymous { get; set; }

        public VocabDTO(int id, string lesson, string image, string word, string pronunciation, string meaning, string synonymous, string antonymous)
        {
            Id = id;
            Lesson = lesson;
            Image = image;
            Word = word;
            Pronunciation = pronunciation;
            Meaning = meaning;
            Synonymous = synonymous;
            Antonymous = antonymous;
        }
    }
}
