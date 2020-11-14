using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.ConnectionDB;
using ToeicExamOnline.Repositories.Entities;
using ToeicExamOnline.Repositories.Interfaces;

namespace ToeicExamOnline.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ConnectDB connectDB;
        public LoginRepository()
        {
            connectDB = new ConnectDB();
        }
        public bool login(User user)
        {
            //string connectionString = "Server=localhost;Port=3306;Database=toeicexam;Uid=root;Pwd=Lexuanhung123.;";
            //// Khởi tạo sql connection
            //MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            //MySqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "SELECT * FROM User";

            ////Mở kết nối
            //sqlConnection.Open();

            //MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //while (sqlDataReader.Read())
            //{
            //    for (int i = 0; i<sqlDataReader.FieldCount; i++)
            //    {
            //        var colName = sqlDataReader.GetName(i);
            //        var value = sqlDataReader.GetValue(i);
            //    }
            //}
            return connectDB.checkExistUser(user);
        }

        public bool register(User user)
        {
            return connectDB.createAccount(user);
        }
    }
}
