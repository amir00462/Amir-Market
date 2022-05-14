using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AmirMarket.DAL
{
    public class UserDao
    {

        public string Login(string username, string password)
        {
            string returnType = "error";

            if (IsUserExist(username, password))
            {
                returnType = "signIn";

            }
            else
            {
                var signUpResult = SignUpUser(username, password);
                if(signUpResult)
                {
                    returnType = "signUp";
                }

            }

            return returnType;
        }

        private bool SignUpUser(string username, string password)
        {
            bool returnType = true;

            try
            {

                // connect to database
                string sqlConnectionString = "Data Source=FARADARS;Initial Catalog=model;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
                sqlConnection.Open();

                // my query
                string query = "INSERT INTO Users (username, password)";
                query += " VALUES (@username, @password)";

                // create command
                SqlCommand myCommand = new SqlCommand(query, sqlConnection);
                myCommand.Parameters.AddWithValue("@username", username);
                myCommand.Parameters.AddWithValue("@password", password);

                // run command
                myCommand.ExecuteNonQuery();

                // close database
                sqlConnection.Close();

            }
            catch
            {
                returnType = false;
            }

            return returnType;
        }

        private bool IsUserExist(string username, string password)
        {

            // connect to database
            string sqlConnectionString = "Data Source=FARADARS;Initial Catalog=model;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();

            // create command
            SqlCommand cmd = new SqlCommand("Select count(*) from Users where username= @Username AND password= @Password", sqlConnection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            // execute
            var result = cmd.ExecuteScalar();

            // close database
            sqlConnection.Close();

            if (result == null || result.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }


        }


    }
}
