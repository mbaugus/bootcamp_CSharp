using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy2
{
    class Person
    {
        public string FirstName { get; set; }
        public char MiddleInitial { get; set; }
        public string LastName { get; set; }

        string _eyeColor;
        public string EyeColor { get { return _eyeColor; } set { _eyeColor = value; } }

        public string JobTitle { get; set; }
        public string BirthPlace;
        public string SocialSecurityNumber;
        public string DriversLicenseNumber;
        public short CreditScore;
        public bool isMarried; //
        public int Id; // respective to the SQL primary key
        public DateTime DOB;
        public short Height; // inches 
        public short Weight; // pounds
        
        public string DumpInfo()
        {
            var sb = new StringBuilder();
            sb.Append("Name: " +
                FirstName + " " + LastName + "\n" + "Eye color: " +
                EyeColor + "\nJob Title: " +
                JobTitle + "\nPlace of Birth: " +
                BirthPlace + "\nDrivers License: " + 
                DriversLicenseNumber + "\nSocial Security Number: " + 
                SocialSecurityNumber + "\nCredit Score: " + 
                CreditScore + "\nMarried: " + 
                isMarried + "\nDate of Birth: " +
                DOB + "\nHeight: " +
                Height + "\nWeight: " +
                Weight
                );

            return sb.ToString();
        }
    }
}
