using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Interfaces;
using ToeicExamOnline.Services.Interfaces;

namespace ToeicExamOnline.Services
{
    public class ToeicExamService : IToeicExamService
    {
        private readonly IToeicExamRepository _toeicExamRepositoryInterface;
        public ToeicExamService(IToeicExamRepository toeicExamRepositoryInterface)
        {
            _toeicExamRepositoryInterface = toeicExamRepositoryInterface;
        }
        public ActionServiceResult GetListExam()
        {
            return _toeicExamRepositoryInterface.GetListExam();
        }

        public ActionServiceResult GetQuestionPart1ByYearAndExamNo(int year, int examNo)
        {
            var res = _toeicExamRepositoryInterface.GetQuestionPart1ByYearAndExamNo(year, examNo);
            return res.Result;
        }

        public ActionServiceResult GetQuestionPart2ByYearAndExamNo(int year, int examNo)
        {
            var res = _toeicExamRepositoryInterface.GetQuestionPart2ByYearAndExamNo(year, examNo);
            return res.Result;
        }

        public ActionServiceResult GetQuestionPart3ByYearAndExamNo(int year, int examNo)
        {
            var res = _toeicExamRepositoryInterface.GetQuestionPart3ByYearAndExamNo(year, examNo);
            return res.Result;
        }

        public ActionServiceResult GetQuestionPart4ByYearAndExamNo(int year, int examNo)
        {
            var res = _toeicExamRepositoryInterface.GetQuestionPart4ByYearAndExamNo(year, examNo);
            return res.Result;
        }

        public ActionServiceResult GetQuestionPart5ByYearAndExamNo(int year, int examNo)
        {
            var res = _toeicExamRepositoryInterface.GetQuestionPart5ByYearAndExamNo(year, examNo);
            return res.Result;
        }

        public ActionServiceResult GetQuestionPart6ByYearAndExamNo(int year, int examNo)
        {
            var res = _toeicExamRepositoryInterface.GetQuestionPart6ByYearAndExamNo(year, examNo);
            return res.Result;
        }
    }
}
