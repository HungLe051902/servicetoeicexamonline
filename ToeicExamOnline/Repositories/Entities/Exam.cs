using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline.Repositories.Entities
{
    public class Exam
    {
        public Guid ExamID { get; set; }
        public int ExamCode { get; set; }
        public string ExamName { get; set; }
        public int Year { get; set; }
    }
}
