using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline.Repositories.Interfaces
{
    public interface IToeicExamRepository
    {
        public ActionServiceResult GetListExam();
    }
}
