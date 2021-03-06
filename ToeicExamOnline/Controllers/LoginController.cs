﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ToeicExamOnline.Repositories.Entities;
using ToeicExamOnline.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToeicExamOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginServiceInterface;

        public LoginController(ILoginService loginServiceInterface)
        {
            _loginServiceInterface = loginServiceInterface;
        }
        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        [Route("/api/[controller]/login")]
        public ActionServiceResult Login([FromBody] User user)
        {
            var res = _loginServiceInterface.login(user);
            return res;
        }

        [HttpPost]
        [Route("/api/[controller]/register")]
        public ActionServiceResult Register([FromBody] User user)
        {
            var res = _loginServiceInterface.register(user);
            return res;
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
