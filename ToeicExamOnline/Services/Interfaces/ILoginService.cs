using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Entities;

namespace ToeicExamOnline.Services.Interface
{
    public interface ILoginService
    {
        public bool login(User user);

        public bool register(User user);
    }
}
