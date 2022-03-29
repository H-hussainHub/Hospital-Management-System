using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HospManSys
{
    public class Financer
    {
        private string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys";

        public Boolean HasInsurance(int nhs_number)
        {
            Boolean insured = false;
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT `InsuranceID` FROM `patient` WHERE `NHS_Number` = "+nhs_number+"";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                if (reader.IsDBNull(0))
                {
                    insured = false;
                } else
                {
                    insured = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            hospmansysDB.Close();

            return insured;
        }

        private void InsurancePay()
        {
            //Email Insurance Company For Payment
        }

        private void SelfPay()
        {
            //Email Patient for payment using HealthCarePro payment system
        }

        public void GenerateInvoice(int nhs_number, int referral_id)
        {
            if (HasInsurance(nhs_number))
            {
                InsurancePay();
            } else
            {
                SelfPay();
            }

            //Assign the referral ID to the Patient 
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();
                string sql = "UPDATE `patient_referral` SET `Invoiced` = '1' " +
                    "WHERE `patient_referral`.`NHS_Number` = "+nhs_number+" AND `patient_referral`.`referral_id` = "+referral_id+"";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //close database
            hospmansysDB.Close();

        }

    }
}
