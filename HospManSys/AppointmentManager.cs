using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HospManSys
{
    public class AppointmentManager
    {
        private string connStr = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospmansys";

        public AppointmentManager()
        {
            
        }

        public Boolean ApproveReferral(Referral referral)
        {
            bool approved = false;

            //Assign the referral ID to the Patient 
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();
                string sql = "UPDATE `patient_referral` SET `approved` = '1', `DateOfApproval` = '"+DateTime.Now+"' " +
                    "WHERE `patient_referral`.`NHS_Number` = "+referral.NHS_Number+" AND `patient_referral`.`referral_id` = "+referral.ID+"";
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                cmd.ExecuteNonQuery();
                approved = true;
            }
            catch (Exception ex)
            {
                approved = false;
                throw ex;
            }

            //close database
            hospmansysDB.Close();

            EmailPatient();

            return approved;
        }

        private void EmailPatient()
        {
            //Use HealthCarePro system to email patient that they need to book an appointment
        }

        //Check if the patient is already in database
        private Boolean VerifyPatientInDatabase(int nhs_number)
        {
            bool verified = false;
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            try
            {
                //open database
                hospmansysDB.Open();

                string sql = "SELECT referral.NHS_NUMBER FROM referral, patient WHERE patient.NHS_Number = "+ nhs_number ;
                MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
                MySqlDataReader reader = cmd.ExecuteReader();

                //If there are rows then is already a patient
                if (reader.HasRows)
                {
                    verified = true;
                } else // No rows so enroll patient
                {
                    verified = false;
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }

            //close database
            hospmansysDB.Close();

            return verified;
        }

        public Boolean AssignReferralToPatient(Referral referral)
        {
            //Assign the referral ID to the Patient 
            MySqlConnection hospmansysDB = new MySqlConnection(connStr);

            //open database
            hospmansysDB.Open();

            string sql = "INSERT INTO `patient_referral` (`NHS_Number`, `referral_id`, `approved`) VALUES ("+referral.NHS_Number+", "+referral.ID+", '0')";
            MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);
            cmd.ExecuteNonQuery();
           
            //close database
            hospmansysDB.Close();

            return true;
        }

        //Take in a referrence and check if patient isnt in database then enroll them into database
        public Boolean EnrollPatient(Referral referralDetails)
        {
            Boolean enrolled = false;

            //If we cant verify patient in database then add to database
            if (!VerifyPatientInDatabase(referralDetails.NHS_Number))
            {          
                MySqlConnection hospmansysDB = new MySqlConnection(connStr);

                //Enrolled Patient into database
                try
                {
                    //open database
                    hospmansysDB.Open();

                    string sql = "INSERT INTO `patient` (`NHS_Number`, `user_id`, `InsuranceID`, `name`, `DateOfBirth`, `email`, `phonenumber`) " +
                        "VALUES ('" + referralDetails.NHS_Number + "', NULL, NULL, '" + referralDetails.Name + "', '" + referralDetails.DateOfBirth + "', '" + referralDetails.Email + "', '" + referralDetails.Phonenumber + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, hospmansysDB);             
                    cmd.ExecuteNonQuery();

                    enrolled = true;
                }
                catch (Exception e)
                {
                    throw e;
                }

                //close database
                hospmansysDB.Close();
            } else
            {
                //Dont Enroll into the database
                enrolled = false;
            }

            return enrolled;
        }
    }
}
