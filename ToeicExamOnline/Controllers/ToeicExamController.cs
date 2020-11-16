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
        [HttpGet]
        [Route("/api/ToeicExam/exam")]
        public ActionServiceResult GetAllExam()
        {
            return _toeicExamServiceInterface.GetListExam();
        }

        [HttpGet]
        [Route("/api/ToeicExam/exam/part1")]
        public ActionServiceResult GetQuestionPart1ByYearAndExamNo(int year, int examNo)
        {
            return _toeicExamServiceInterface.GetQuestionPart1ByYearAndExamNo(year, examNo);
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
