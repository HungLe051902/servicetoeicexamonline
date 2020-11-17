using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline.Services.Interfaces
{
    public interface IToeicExamService
    {
        public ActionServiceResult GetListExam();

        public ActionServiceResult GetQuestionPart1ByYearAndExamNo(int year, int examNo);
        public ActionServiceResult GetQuestionPart2ByYearAndExamNo(int year, int examNo);
    }
}
