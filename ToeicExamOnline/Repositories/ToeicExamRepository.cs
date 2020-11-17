﻿using MySql.Data.MySqlClient;
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

        public async Task<ActionServiceResult> GetQuestionPart1ByYearAndExamNo(int year, int examNo)
        {
            using (var databaseConnector = new DatabaseConnector<Part1>())
            {
                List<MySqlParameter> list = new List<MySqlParameter>();
                list.Add(new MySqlParameter("@Year", year));
                list.Add(new MySqlParameter("@ExamNo", examNo));
                var data = await databaseConnector.getDataWithParams("Proc_GetQuestionPart1ByYearAndExamNo", list);
                return new ActionServiceResult(200, "Lấy dữ liệu câu hỏi part1 thành công", data);
            }
        }

        public async Task<ActionServiceResult> GetQuestionPart2ByYearAndExamNo(int year, int examNo)
        {
            using (var databaseConnector = new DatabaseConnector<Part1>())
            {
                List<MySqlParameter> list = new List<MySqlParameter>();
                list.Add(new MySqlParameter("@Year", year));
                list.Add(new MySqlParameter("@ExamNo", examNo));
                var data = await databaseConnector.getDataWithParams("Proc_GetQuestionPart2ByYearAndExamNo", list);
                return new ActionServiceResult(200, "Lấy dữ liệu câu hỏi part2 thành công", data);
            }
        }
    }
}
