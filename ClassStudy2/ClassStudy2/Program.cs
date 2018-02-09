using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mPerson = new Person
            {
                BirthPlace = "Kentucky",
                CreditScore = 740,
                DriversLicenseNumber = "SJ2024242",
                EyeColor = "Brown",
                Height = 72,
                Id = 2,
                isMarried = true,
                JobTitle = "Clerk",
                DOB = new DateTime(1984, 4, 18),
                FirstName = "Bob",
                LastName = "Smith",
                MiddleInitial = 'R',
                SocialSecurityNumber = "029-21-4125",
                Weight = 174
            };

            string Eye = mPerson.EyeColor;
            mPerson.EyeColor = "Blue";

            Console.WriteLine(mPerson.DumpInfo());
        }
    }
}
