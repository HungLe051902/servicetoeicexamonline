using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Entities;

namespace ToeicExamOnline.Authorization
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(User user);
    }
}
