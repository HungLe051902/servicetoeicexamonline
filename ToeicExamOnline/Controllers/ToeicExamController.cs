using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToeicExamOnline.Repositories.Entities;
using ToeicExamOnline.Services.Interfaces;

namespace ToeicExamOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToeicExamController : ControllerBase
    {
        private readonly IToeicExamService _toeicExamServiceInterface;
        public ToeicExamController(IToeicExamService toeicExamServiceInterface)
        {
            _toeicExamServiceInterface = toeicExamServiceInterface;
        }

        // Lấy thông tin tất cả các đề thi
        [HttpGet]
        [Route("/api/ToeicExam/exam")]
        public ActionServiceResult GetAllExam()
        {
            return _toeicExamServiceInterface.GetListExam();
        }

        // Lấy câu hỏi part1
        [HttpGet]
        [Route("/api/ToeicExam/exam/part1")]
        public ActionServiceResult GetQuestionPart1ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart1ByYearAndExamNo(year, examNo);
        }

        // Lấy câu hỏi part2
        [HttpGet]
        [Route("/api/ToeicExam/exam/part2")]
        public ActionServiceResult GetQuestionPart2ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart2ByYearAndExamNo(year, examNo);
        }

        // Lấy câu hỏi part3
        [HttpGet]
        [Route("/api/ToeicExam/exam/part3")]
        public ActionServiceResult GetQuestionPart3ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart3ByYearAndExamNo(year, examNo);
        }

        // Lấy câu hỏi part4
        [HttpGet]
        [Route("/api/ToeicExam/exam/part4")]
        public ActionServiceResult GetQuestionPart4ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart4ByYearAndExamNo(year, examNo);
        }

        // Lấy câu hỏi part5
        [HttpGet]
        [Route("/api/ToeicExam/exam/part5")]
        public ActionServiceResult GetQuestionPart5ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart5ByYearAndExamNo(year, examNo);
        }

        // Lấy câu hỏi part6
        [HttpGet]
        [Route("/api/ToeicExam/exam/part6")]
        public ActionServiceResult GetQuestionPart6ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart6ByYearAndExamNo(year, examNo);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToeicExamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToeicExamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToeicExamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
