using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline.Repositories.Interfaces
{
    public interface IToeicExamRepository
    {
        public ActionServiceResult GetListExam();

        public Task<ActionServiceResult> GetQuestionPart1ByYearAndExamNo(int year, int examNo);

        public Task<ActionServiceResult> GetQuestionPart2ByYearAndExamNo(int year, int examNo);
    }
}
