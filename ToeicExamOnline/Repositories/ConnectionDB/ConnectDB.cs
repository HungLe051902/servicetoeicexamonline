﻿using Microsoft.AspNetCore.Mvc.Filters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Entities;

namespace ToeicExamOnline.Repositories.ConnectionDB
{
    public class ConnectDB
    {
        private string connectionString = "Server=MYSQL5032.site4now.net;Database=db_a6a606_toeicdb;Uid=a6a606_toeicdb;Pwd=12345678@Abc";
        private MySqlConnection mySqlConnection;
        private MySqlCommand mysqlCommand;
        public ConnectDB() {
            mySqlConnection = new MySqlConnection(connectionString);
            mysqlCommand = mySqlConnection.CreateCommand();
        }
        public List<User> getUsers()
        {
            mySqlConnection.Open();
            var users = new List<User>();
            mysqlCommand.CommandText = "SELECT * FROM User";
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();

            while (mysqlDataReader.Read())
            {
                var user = new User();
                for (int i = 0; i < mysqlDataReader.FieldCount; i++)
                {
                    var colName = mysqlDataReader.GetName(i);
                    var value = mysqlDataReader.GetValue(i);
                    var property = user.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(user, value);
                    }
                }
                users.Add(user);
            }
            mySqlConnection.Close();
            return users;
        }
        public bool checkExistUser(User user)
        {
            mySqlConnection.Open();
            mysqlCommand.CommandText = "SELECT * FROM User WHERE UserName='" + user.UserName + "' AND Password='" + user.Password + "'";
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
            bool isExist = false;
            while (mysqlDataReader.Read())
            {
                isExist = true;
            }
            mySqlConnection.Close();
            return isExist;
        }

        public bool createAccount(User user)
        {
            if (checkExistUser(user) == false)
            {
                mySqlConnection.Open();
                mysqlCommand.CommandText = "INSERT INTO User(UserName, Password)  VALUES(@param1, @param2)";
                mysqlCommand.Parameters.AddWithValue("@param1", user.UserName);
                mysqlCommand.Parameters.AddWithValue("@param2", user.Password);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
