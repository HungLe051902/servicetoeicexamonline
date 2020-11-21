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
        public Task<ActionServiceResult> GetQuestionPart3ByYearAndExamNo(int year, int examNo);
        public Task<ActionServiceResult> GetQuestionPart4ByYearAndExamNo(int year, int examNo);
        public Task<ActionServiceResult> GetQuestionPart5ByYearAndExamNo(int year, int examNo);
        public Task<ActionServiceResult> GetQuestionPart6ByYearAndExamNo(int year, int examNo);
    }
}
