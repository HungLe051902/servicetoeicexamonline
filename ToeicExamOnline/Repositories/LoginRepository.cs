﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Authorization;
using ToeicExamOnline.Helpers;
using ToeicExamOnline.Repositories.ConnectionDB;
using ToeicExamOnline.Repositories.Entities;
using ToeicExamOnline.Repositories.Interfaces;

namespace ToeicExamOnline.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;
        public LoginRepository(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }
        public ActionServiceResult login(User user)
        {
            bool result = false;
            string token = "";
            using (var databaseConnector = new DatabaseConnector<User>())
            {
                var listUser = databaseConnector.getData("Proc_GetAllUser");
                foreach (User usr in listUser)
                {
                    if (usr.UserName == user.UserName && usr.Password == LoginHelper.MD5Hash(user.Password))
                    {
                        result = true;
                        token = jwtAuthenticationManager.Authenticate(usr);
                        break;
                    }
                }
            }
            if (result == true)
            {
                return new ActionServiceResult(200, "Đăng nhập thành công", token);
            }
            else
            {
                return new ActionServiceResult(600, "Thông tin sai", result);
            }
        }

        public ActionServiceResult register(User user)
        {
            bool isExistAccount = false;
            using (var databaseConnector = new DatabaseConnector<User>())
            {
                var listUser = databaseConnector.getData("Proc_GetAllUser");
                foreach (User usr in listUser)
                {
                    if (usr.UserName == user.UserName)
                    {
                        isExistAccount = true;
                        break;
                    }
                }
            }
            if (isExistAccount == true)
            {
                return new ActionServiceResult(601, "Đã có tài khoản này trên hệ thống", !isExistAccount);
            }
            else
            {
                using(var databaseConnector = new DatabaseConnector<User>())
                {
                    List<MySqlParameter> list = new List<MySqlParameter>();
                    list.Add(new MySqlParameter("@UserName", user.UserName));
                    list.Add(new MySqlParameter("@Password", LoginHelper.MD5Hash(user.Password)));
                    databaseConnector.insertToDB("Proc_CreateAccount", list);
                }
                return new ActionServiceResult(200, "Đăng ký thành công", !isExistAccount);
            }
        }
    }
}
