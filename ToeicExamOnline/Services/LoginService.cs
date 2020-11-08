using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Entities;
using ToeicExamOnline.Repositories.Interfaces;
using ToeicExamOnline.Services.Interface;

namespace ToeicExamOnline.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public bool login(User user)
        {
            var res = _loginRepository.login(user);
            return res;
            //if (user.UserName == "test" && user.Password == "123456")
            //{
            //    return "Đăng nhập thành công!";
            //}
            //else
            //{
            //    return "Đăng nhập thất bại";
            //}

        }
    }
}
