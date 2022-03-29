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
    public partial class Login : Form
    {
        User user;

        public Login()
        {
            InitializeComponent();
            user = new User();
        }

        private void openFormFromRole()
        {
            switch (user.Role)
            {
                case "STAFF":
                    this.Hide();
                    frmStaff frmStaff = new frmStaff(user);
                    frmStaff.ShowDialog();
                    this.Close();
                    break;
                case "PATIENT":
                    MessageBox.Show("Open: " + user.Role);
                    //open patient form
                    break;
                case "INSURANCE":
                    MessageBox.Show("Open: " + user.Role);
                    break;
                default:
                    //default form
                    MessageBox.Show("Unsupported Role");
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Login(tbUsername.Text, tbPassword.Text))
            {
                //Goto Form
                openFormFromRole();
            } else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
