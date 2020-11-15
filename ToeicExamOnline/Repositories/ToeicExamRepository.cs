using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.ConnectionDB;
using ToeicExamOnline.Repositories.Entities;
using ToeicExamOnline.Repositories.Interfaces;

namespace ToeicExamOnline.Repositories
{
    public class ToeicExamRepository : IToeicExamRepository
    {
        public ActionServiceResult GetListExam()
        {
            using (var databaseConnector = new DatabaseConnector<Exam>())
            {
                var data = databaseConnector.getData("Proc_GetListExam");
                return new ActionServiceResult(200, "Lấy dữ liệu các đề thi thành công", data);
            }
        }
    }
}
