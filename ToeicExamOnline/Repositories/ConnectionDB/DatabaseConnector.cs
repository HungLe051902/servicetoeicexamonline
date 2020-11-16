using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToeicExamOnline.Repositories.Entities;

namespace ToeicExamOnline.Repositories.ConnectionDB
{
    public class DatabaseConnector<T> : IDisposable where T : new()
    {
        private string connectionString = "Server=MYSQL5032.site4now.net;Database=db_a6a606_toeicdb;Uid=a6a606_toeicdb;Pwd=12345678@Abc";
        private MySqlConnection mySqlConnection;
        private MySqlCommand mysqlCommand;
        public DatabaseConnector()
        {
            mySqlConnection = new MySqlConnection(connectionString);
            mysqlCommand = mySqlConnection.CreateCommand();
            mysqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            mySqlConnection.Open();
        }

        public void setTypeCommand()
        {

        }
        //public List<User> getUsers()
        //{
        //    mySqlConnection.Open();
        //    var users = new List<User>();
        //    mysqlCommand.CommandText = "SELECT * FROM User";
        //    MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();

        //    while (mysqlDataReader.Read())
        //    {
        //        var user = new User();
        //        for (int i = 0; i < mysqlDataReader.FieldCount; i++)
        //        {
        //            var colName = mysqlDataReader.GetName(i);
        //            var value = mysqlDataReader.GetValue(i);
        //            var property = user.GetType().GetProperty(colName);
        //            if (property != null)
        //            {
        //                property.SetValue(user, value);
        //            }
        //        }
        //        users.Add(user);
        //    }
        //    mySqlConnection.Close();
        //    return users;
        //}
        public IEnumerable<T> getData(string storeProcedureName)
        {
            var lists = new List<T>();
            mysqlCommand.CommandText = storeProcedureName;
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
            while (mysqlDataReader.Read())
            {
                T obj = new T();
                for (int i = 0; i < mysqlDataReader.FieldCount; i++)
                {
                    var colName = mysqlDataReader.GetName(i);
                    var value = mysqlDataReader.GetValue(i);
                    var property = obj.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(obj, value);
                    }
                }
                lists.Add(obj);
            }
            return lists;
        }

        public Task<IEnumerable<T>> getDataWithParams(string storeProcedureName, List<MySqlParameter> listParam)
        {
            List<T> lists = new List<T>();
            mysqlCommand.CommandText = storeProcedureName;
            mysqlCommand.Parameters.AddRange(listParam.ToArray<MySqlParameter>());
            MySqlDataReader mysqlDataReader = mysqlCommand.ExecuteReader();
            while (mysqlDataReader.Read())
            {
                T obj = new T();
                for (int i = 0; i < mysqlDataReader.FieldCount; i++)
                {
                    var colName = mysqlDataReader.GetName(i);
                    var value = mysqlDataReader.GetValue(i);
                    var property = obj.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(obj, value);
                    }
                }
                lists.Add(obj);
            }
            return Task.FromResult(lists.AsEnumerable());
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

        public int insertToDB(string storeProcedureName, List<MySqlParameter> listParam)
        {
            mysqlCommand.CommandText = storeProcedureName;
            mysqlCommand.Parameters.AddRange(listParam.ToArray<MySqlParameter>());
            return mysqlCommand.ExecuteNonQuery();
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

        public void Dispose()
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }
    }
}
