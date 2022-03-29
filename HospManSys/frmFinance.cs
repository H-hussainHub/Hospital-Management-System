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
    public partial class frmFinance : Form
    {
        Financer finance_clerk;

        public frmFinance()
        {
            InitializeComponent();
            GetUnpaidInvoices();
            finance_clerk = new Financer();
        }

        private void GetUnpaidInvoices()
        {
            string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys;Convert Zero Datetime=True";
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT * FROM `patient_referral` WHERE invoiced = 0 AND approved = 1";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dgvInvoices.DataSource = new BindingSource(reader, null);
                } else
                {
                    dgvInvoices.DataSource = null;
                }
            }
            catch (Exception)
            {

                throw;
            }

            hospmansysDB.Close();
        }

        private void UpdatedgvInvoices()
        {
            GetUnpaidInvoices();
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            int nhs_number = int.Parse(dgvInvoices.SelectedCells[0].Value.ToString());
            int referral_id = int.Parse(dgvInvoices.SelectedCells[1].Value.ToString());
            finance_clerk.GenerateInvoice(nhs_number,referral_id);

            UpdatedgvInvoices();
        }
    }
}
