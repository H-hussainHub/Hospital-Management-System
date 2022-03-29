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
    public partial class frmAppointmentManagement : Form
    {
        AppointmentManager appointmentManager;
        Mode mode;

        enum Mode
        {
            EnrollPatient = 1,
            ApproveReferral = 2
        }

        public frmAppointmentManagement()
        {
            InitializeComponent();
            appointmentManager = new AppointmentManager();
            //Display unreferred patients by default
            if (GetUnenrolledReferrals())
            {
                mode = Mode.EnrollPatient;
            } else
            {
                mode = Mode.ApproveReferral;
                UpdatePatientDataPanel();
            }
        }

        private void UpdatePatientDataPanel()
        {
            if (mode == Mode.EnrollPatient)
            {
                lbldgvTitle.Text = "Enroll Patients";
                btnEnroll.Show();
                btnApprove.Hide();
                GetUnenrolledReferrals();
            } else
            {
                lbldgvTitle.Text = "Approve Referrals";
                btnEnroll.Hide();
                btnApprove.Show();
                GetUnapprovedReferrals();
            }
        }

        private Boolean GetUnapprovedReferrals()
        {
            Boolean unapprovedReferrals = false;
            string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys;Convert Zero Datetime=True";
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            //open database
            hospmansysDB.Open();

            string sql = "SELECT * FROM `patient_referral` WHERE approved = 0";
            MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                dgvPatientReferral.DataSource = new BindingSource(reader, null);
                unapprovedReferrals = true;
            }
            else
            {
                //No records to approve
                dgvPatientReferral.DataSource = null;
                mode = Mode.ApproveReferral;
                unapprovedReferrals = false;
            }

            hospmansysDB.Close();

            return unapprovedReferrals;
        }

        private Boolean GetUnenrolledReferrals()
        {
            Boolean unenrolledReferrals = false;
            string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys";
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            //open database
            hospmansysDB.Open();

            string sql = "SELECT referral.* FROM referral WHERE referral.NHS_NUMBER NOT IN (SELECT patient_referral.NHS_Number FROM patient_referral)";
            MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                dgvPatientReferral.DataSource = new BindingSource(reader, null);
                unenrolledReferrals = true;
            } else
            {
                //No records to enroll
                dgvPatientReferral.DataSource = null;
                mode = Mode.EnrollPatient;
                unenrolledReferrals = false;
            }

            hospmansysDB.Close();

            return unenrolledReferrals;
        }

        private Referral GetReferral()
        {
            //Enroll Patient into database

            //Get selected data as referral and pass to appointment manager
            Referral referral = new Referral();

            //Selection mode is on single row so can use first row
            foreach (DataGridViewRow row in dgvPatientReferral.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    switch (cell.OwningColumn.Name.ToUpper())
                    {
                        case "ID":
                            referral.ID = int.Parse(cell.Value.ToString());
                            break;
                        case "REFERRAL_ID":
                            referral.ID = int.Parse(cell.Value.ToString());
                            break;
                        case "NHS_NUMBER":
                            referral.NHS_Number = int.Parse(cell.Value.ToString());
                            break;
                        case "NAME":
                            referral.Name = cell.Value.ToString();
                            break;
                        case "EMAIL":
                            referral.Email = cell.Value.ToString();
                            break;
                        case "AGE":
                            referral.Age = int.Parse(cell.Value.ToString());
                            break;
                        case "DATEOFBIRTH":
                            referral.DateOfBirth = DateTime.Parse(cell.Value.ToString());
                            break;
                        case "PHONENUMBER":
                            referral.Phonenumber = cell.Value.ToString();
                            break;
                        case "DATEOFREFERRAL":
                            referral.DateOfReferral = DateTime.Parse(cell.Value.ToString());
                            break;
                        case "GP":
                            referral.Gp = cell.Value.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return referral;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Referral referral = GetReferral();
            //Enroll the referred patient into the database
            appointmentManager.EnrollPatient(referral);
            appointmentManager.AssignReferralToPatient(referral);
            UpdatePatientDataPanel();
        }

        private void btnUpdateDGV_Click(object sender, EventArgs e)
        {
            UpdatePatientDataPanel();
        }

        private void btnApproveReferrals_Click(object sender, EventArgs e)
        {
            mode = Mode.ApproveReferral;
            UpdatePatientDataPanel();
        }

        private void btnApproveReferral_Click(object sender, EventArgs e)
        {
            //Aprove referral
            appointmentManager.ApproveReferral(GetReferral());
            UpdatePatientDataPanel();
        }

        private void btnEnrollPatients_Click(object sender, EventArgs e)
        {
            mode = Mode.EnrollPatient;
            UpdatePatientDataPanel();
        }
    }
}
