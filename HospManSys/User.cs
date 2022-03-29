using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HospManSys
{
    public class User
    {
        private string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys";

        public User()
        {

        }

        public string Username { get; set; }
        public int ID { get; set; }
        public string Role { get; set; }

        /* Get userdata from database and check for correct credentials */
        public Boolean Login(string username, string password)
        {
            Boolean loginsucessfull = false;

            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT * FROM `user` WHERE `username`= '" + username + "' AND `password`= '" + password + "'";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                //Check a user was found
                if (reader.HasRows)
                {
                    //Check username and password agaisnt input data
                    if (reader.GetString("username").ToUpper() == username.ToUpper() && reader.GetString("password").ToUpper() == password.ToUpper())
                    {
                        getRoleDescription(reader.GetInt16("role"));
                        loginsucessfull = true;

                        ID = reader.GetInt16("id");
                        Username = username;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            //close database
            hospmansysDB.Close();

            if (loginsucessfull)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void getRoleDescription(int roleID)
        {
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT `role` FROM `user_role` WHERE `ID` = " + roleID;
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                //Check for data
                if (reader.HasRows)
                {
                    Role = reader.GetString("role").ToUpper();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            //close database
            hospmansysDB.Close();
        }

        private Boolean ChangePassword()
        {
            return false;
        }

        private void ResetPassword()
        {

        }
    }
}
