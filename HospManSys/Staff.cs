using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HospManSys
{
    public class Staff : User
    {
        private string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys";

        public Staff(User user)
        {
            ID = user.ID;
            Role = user.Role;
            Department = new List<string>();

            getDepartments();
        }

        public int StaffID { get; }
        public List<string> Department { get; set; }

        //Will get all department staff member is a part of
        private void getDepartments()
        {
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT dep.name FROM `staff` staff, `department` dep WHERE staff.user_id = 2 AND dep.id = staff.department_id";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                //Check for data
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Department.Add(reader.GetString("name"));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            //close database
            hospmansysDB.Close();

        }

    }
}
