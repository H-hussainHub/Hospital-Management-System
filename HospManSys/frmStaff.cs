using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospManSys
{
    public partial class frmStaff : Form
    {
        Staff staff;

        public frmStaff(User user)
        {
            InitializeComponent();
            staff = new Staff(user);

            ShowAvailableDepartmentButtons();
        }

        private void ShowAvailableDepartmentButtons()
        {
            foreach (string department in staff.Department)
            {
                switch (department.ToUpper())
                {
                    case "CONSULTANT_CLERK":
                        btnConsultant.Show();
                        break;
                    case "FINANCIAL_CLERK":
                        btnFinance.Show();
                        break;
                    case "APPOINTMENT_MANAGER":
                        btnAppointmentManagement.Show();
                        break;
                    case "SENIOR_MANAGEMENT":
                        btnSeniorManagement.Show();
                        break;
                    case "ADMINISTRATOR":
                        btnAdministrator.Show();
                        break;
                    default:
                        MessageBox.Show("No button for department " + department);
                        break;
                }
            }
        }

        private void btnAppointmentManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAppointmentManagement frmAppointmentManagement = new frmAppointmentManagement();
            frmAppointmentManagement.ShowDialog();
            this.Show();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFinance frmFinance = new frmFinance();
            frmFinance.ShowDialog();
            this.Show();
        }

        private void btnSeniorManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeniorManagement frmSeniorManagement = new frmSeniorManagement();
            frmSeniorManagement.ShowDialog();
            this.Show();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();
            this.Show();
        }

        private void btnConsultant_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultant frmConsultant = new frmConsultant();
            frmConsultant.ShowDialog();
            this.Show();
        }
    }
}
