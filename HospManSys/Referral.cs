using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospManSys
{
    public class Referral
    {
        public Referral()
        {

        }

        public Referral(int id, int nhs_number, string name, string email, int age, DateTime dob, string phonenumber, DateTime dateOfReferral, string gp, Boolean approved)
        {
            ID = id;
            NHS_Number = nhs_number;
            Name = name;
            Email = email;
            Age = age;
            DateOfBirth = dob;
            Phonenumber = phonenumber;
            DateOfReferral = dateOfReferral;
            Gp = gp;
            Approved = approved;
        }

        public int ID { get; set; }
        public int NHS_Number { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phonenumber { get; set; }
        public DateTime DateOfReferral { get; set; }
        public string Gp { get; set; }
        public Boolean Approved { get; set; }
    }
}
