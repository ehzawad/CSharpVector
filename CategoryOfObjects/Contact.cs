using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryOfObjects
{
    public class Contact
    {
        string personName;
        string personId;
        int age;
        string mobileNumber;
        char gender;

        public Contact()
        {
        }

        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;

        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("Person Name: {0}\nID: {1}\nAge: {2}\nMobile Number: {3}\nGender: {4}\n", personName, personId, age, mobileNumber, gender);

        }

        public void DetectMobileOperator()
        {
            if (mobileNumber.StartsWith("017"))
            {
                Console.WriteLine("GP operator");
            }
            else if (mobileNumber.StartsWith("019"))
            {
                Console.WriteLine("Banglalink operator");
            }
            else if (mobileNumber.StartsWith("018"))
            {
                Console.WriteLine("Robi operator");
            }
            else
            {
                Console.WriteLine("not Sure about operator");
            }

        }
    }
}
