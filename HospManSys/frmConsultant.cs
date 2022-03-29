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
    public partial class frmConsultant : Form
    {
        public frmConsultant()
        {
            InitializeComponent();
            GetReferral();
        }

        private void GetReferral()
        {
            string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys";
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT referral.* FROM referral";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dataGridView1.DataSource = new BindingSource(reader, null);
                }
            }
            catch (Exception)
            {

                throw;
            }

            hospmansysDB.Close();
        }

        private void UploadReferral()
        {
            //Upload selected Referral to the Surgery Clinic System for other Gp's and insurance to access
        }

        private void btnGetReferral_Click(object sender, EventArgs e)
        {
            GetReferral();
        }

        private void btnUploadReferral_Click(object sender, EventArgs e)
        {
            UploadReferral();
            MessageBox.Show("Uploaded Referral to Surgery Clinic System");
        }
    }
}
