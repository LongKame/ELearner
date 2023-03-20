using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishApp.Models
{
    public partial class Part
    {
        public Part()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public string PartName { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
