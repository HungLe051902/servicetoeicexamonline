using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Entities;

namespace ToeicExamOnline.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        public ActionServiceResult login(User user);

        public ActionServiceResult register(User user);
    }
}
