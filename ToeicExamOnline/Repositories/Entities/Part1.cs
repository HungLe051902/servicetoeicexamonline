using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline.Repositories.Entities
{
    public class Part1
    {
        public Guid QuestionID { get; set; }
        public int QuestionNo { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string LinkImg { get; set; }
        public string LinkAudio { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
    }
}
