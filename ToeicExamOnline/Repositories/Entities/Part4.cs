using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline.Repositories.Entities
{
    public class Part4
    {
        public Guid GroupQuestionID { get; set; }
        public int GroupQuestionNo { get; set; }
        public int ExamNo { get; set; }
        public int Year { get; set; }
        public string EngTranscript { get; set; }
        public string VieTranscript { get; set; }
        public string LinkAudio { get; set; }
        public string FirstQuestion { get; set; }
        public string FirstOptionA { get; set; }
        public string FirstOptionB { get; set; }
        public string FirstOptionC { get; set; }
        public string FirstOptionD { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondQuestion { get; set; }
        public string SecondOptionA { get; set; }
        public string SecondOptionB { get; set; }
        public string SecondOptionC { get; set; }
        public string SecondOptionD { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdQuestion { get; set; }
        public string ThirdOptionA { get; set; }
        public string ThirdOptionB { get; set; }
        public string ThirdOptionC { get; set; }
        public string ThirdOptionD { get; set; }
        public string ThirdAnswer { get; set; }
    }
}
