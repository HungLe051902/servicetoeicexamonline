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
        private string connectionString = "Server=localhost;Port=3306;Database=toeicexam;Uid=root;Pwd=Lexuanhung123.;";
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
    }
}
