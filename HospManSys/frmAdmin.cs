using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HospManSys
{
    public partial class frmAdmin : Form
    { 
       string SQLConnection = @"Server=localhost;Database=hospmansys;User ID=root;Password=";

        public frmAdmin()
        {
            InitializeComponent();
            LoadNewStaffinfo();

        }

    public void LoadNewStaffinfo()
    {
        using (MySqlConnection hospmansys = new MySqlConnection(SQLConnection))
        {

            string getStaffQuery = "SELECT * FROM staff";
            DataTable table = new DataTable();
            MySqlCommand commandDatabase = new MySqlCommand(getStaffQuery, hospmansys);
            MySqlDataAdapter adapter = new MySqlDataAdapter(getStaffQuery, SQLConnection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
    }


    private void AddUserBtn_Click(object sender, EventArgs e)

    {
        if (StaffidInput.Text == "" || uIDInput.Text == "" || uUnameInput.Text == "" || uEmailInput.Text == "" || uPhoneNumberInput.Text == "" || uDepartmentInput.SelectedItem.ToString() == "")
        {
            MessageBox.Show("some fields are blank please fill");
        }

        AddUser();
        AddToStaff();
        LoadNewStaffinfo();
    }

    private void AddUser()
    {
        using (MySqlConnection hospmanmsys = new MySqlConnection(SQLConnection))
        {
            hospmanmsys.Open();
            int role = 2;
            string password = "123";
            string addUserQuery = $"INSERT INTO user(ID,username,password,role) VALUES('{uIDInput.Text}','{uUnameInput.Text}','{password}','{role}'); ";
            MySqlCommand commandDatabase1 = new MySqlCommand(addUserQuery, hospmanmsys);
            try
            {
                if (commandDatabase1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("User Inserted");
                }
                else if (commandDatabase1.ExecuteNonQuery() > 1)
                {
                    MessageBox.Show("INVALID! Duplicate user");
                }
                else
                {
                    MessageBox.Show("User Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                hospmanmsys.Close();
            }

        }
    }

    public class Department
    {
        public string name;
        public int id;
        public Department(string deptName, int deptID)
        {
            name = deptName;
            id = deptID;
        }
    }

    private Department GetDepartmentInformation(string param, string flag)
    {
        MySqlConnection hospmansys = new MySqlConnection(SQLConnection);
        Department dept = null;
        string getDepartmentID = "SELECT id,name FROM department WHERE name = @name";
        string queryParam = "@name";


        if (flag == null)
        {
            flag = "name";
        }

        if (flag != "name")
        {
            getDepartmentID = "SELECT id,name FROM department WHERE id = @id";
            queryParam = "@id";
        }

        hospmansys.Open();
        MySqlCommand commandDatabase = new MySqlCommand(getDepartmentID, hospmansys);
        commandDatabase.Parameters.AddWithValue(queryParam, param);
        MySqlDataReader myReader = commandDatabase.ExecuteReader();
        try
        {
            if (myReader.Read())
            {
                dept = new Department(myReader.GetString("name"), myReader.GetInt16("id"));
            }
        }
        finally
        {
            myReader.Close();
            hospmansys.Close();

        }

        return dept;
    }

    private void AddToStaff()
    {
        using (MySqlConnection hospmansys = new MySqlConnection(SQLConnection))
        {
            Department dept = GetDepartmentInformation(uDepartmentInput.SelectedItem.ToString(), null);
            string StaffID = StaffidInput.Text, uID = uIDInput.Text, uName = uUnameInput.Text, uEmail = uEmailInput.Text, uPhoneNumber = uPhoneNumberInput.Text;
            hospmansys.Open();
            string addToStaffQuery = $"INSERT INTO staff(id,user_id,department_id,name,email,phonenumber) VALUES('{StaffID}','{uID}','{dept.id}','{uName}','{uEmail}','{uPhoneNumber}'); ";
            MySqlCommand commandDatabase = new MySqlCommand(addToStaffQuery, hospmansys);
            commandDatabase.ExecuteNonQuery();
            hospmansys.Close();

        }
    }

    private void ClearFormBtn_Click(object sender, EventArgs e)
    {
        StaffidInput.Text = "";
        uIDInput.Text = "";
        uUnameInput.Text = "";
        uEmailInput.Text = "";
        uPhoneNumberInput.Text = "";
        uDepartmentInput.SelectedItem = "";
        enableIDFields(true);
    }


    private void Update_Click(object sender, EventArgs e)
    {

        MySqlConnection hospmansys = new MySqlConnection(SQLConnection);
        hospmansys.Open();
        try
        {
            string StaffID = StaffidInput.Text, uID = uIDInput.Text, uName = uUnameInput.Text, uEmail = uEmailInput.Text, uPhoneNumber = uPhoneNumberInput.Text;
            Department dept = GetDepartmentInformation(uDepartmentInput.SelectedItem.ToString(), null);
            // Find ID first before updating
            string editstaff = $"UPDATE `staff` SET `department_id`='" + dept.id + "',`name`='" + uName + "',`email`='" + uEmail + "',`phonenumber`='" + uPhoneNumber + "' WHERE id =" + StaffID;

            MySqlCommand cmd = new MySqlCommand(editstaff, hospmansys);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("" + uUnameInput.Text + "'s Details is Updated Successfully.. ", "Important Message");
                StaffidInput.Text = "";
                uUnameInput.Text = "";
                uEmailInput.Text = "";
                uPhoneNumberInput.Text = "";
                uDepartmentInput.SelectedItem = "";
                LoadNewStaffinfo();
            }
        }
        catch (Exception excep)
        {
            MessageBox.Show(excep.Message);
        }
        hospmansys.Close();
    }
    private void enableIDFields(bool value)
    {
        if (value == null)
        {
            value = true;
        }

        uIDInput.Enabled = value;
        StaffidInput.Enabled = value;
    }
    private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
    {
        //  string deptName = GetDepartmentNameFromID(name);
        enableIDFields(false);
        Department dept = GetDepartmentInformation(dataGridView1.CurrentRow.Cells[2].Value.ToString(), "id");

        StaffidInput.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        uIDInput.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        uDepartmentInput.SelectedItem = dept.name;
        uUnameInput.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        uEmailInput.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        uPhoneNumberInput.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


    }
    private void Logout_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void DeleteStaff_Click(object sender, EventArgs e)
    {
        MySqlConnection hospmansys = new MySqlConnection(SQLConnection);
        hospmansys.Open();
        string StaffID = StaffidInput.Text;
        string deletestaff = "DELETE FROM staff WHERE id = " + StaffID;
        MySqlCommand cmd = new MySqlCommand(deletestaff, hospmansys);

        if (cmd.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("" + uUnameInput.Text + "'s Details Deleted.. ", "Important Message");
            StaffidInput.Text = "";
            uIDInput.Text = "";
            uUnameInput.Text = "";
            uEmailInput.Text = "";
            uPhoneNumberInput.Text = "";
            uDepartmentInput.SelectedItem = "";
            LoadNewStaffinfo();
        }

    }
    private void searchBtn_Click(object sender, EventArgs e)
    {
        MySqlConnection hospmansys = new MySqlConnection(SQLConnection);
        hospmansys.Open();
        string StaffID = StaffidInput.Text;
        string searchstaff = "SELECT * FROM staff WHERE id = " + StaffID;
        MySqlCommand cmd = new MySqlCommand(searchstaff, hospmansys);
        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            Department dept = GetDepartmentInformation(reader.GetString("department_id"), "id");
            uIDInput.Text = reader.GetString("user_id");
            uUnameInput.Text = reader.GetString("name");
            uEmailInput.Text = reader.GetString("email");
            uPhoneNumberInput.Text = reader.GetString("phonenumber");
            uDepartmentInput.SelectedItem = dept.name;
            LoadNewStaffinfo();
        }
        else
        {
            MessageBox.Show("Staff Not Found");
        }
        hospmansys.Close();
    }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            using (MySqlConnection hospmansys = new MySqlConnection(SQLConnection))
            {
                LoadNewStaffinfo();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
