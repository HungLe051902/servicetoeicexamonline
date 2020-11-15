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
    }
}
