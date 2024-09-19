using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV1.Models
{
    enum Gender { MALE,FEMALE,TRANSGENDER}
    internal class Individual:Customer
    {
        static Individual()
        {
            Console.WriteLine("Derived Class (Individual) Static Constructor");
        }
        public Individual()
        {
            Console.WriteLine("Derived Class (Individual)  Default Constructor");
        }

        public Individual(Gender gender, DateTime DOB)
        {
            Console.WriteLine("Derived Class (Individual)  Parameterized Constructor");
            Gender = gender;
            this.DOB = DOB;
        }

        public Individual(long accountNo, FullName fullName, Address[] addresses, 
            string contactNo, string email, string password, 
            Gender gender, DateTime DOB) : base(accountNo, fullName, 
                addresses, contactNo, email, password)
        {
            Console.WriteLine("Derived Class Parameterized Constructor with base class properties");
            Gender = gender;
            this.DOB = DOB;

        }

        public Gender Gender { get; }

        public DateTime DOB { get; }

        public override string ToString()
        {
            return this.AccountNo + "," + this.FullName.FirstName +","+
                this.FullName.LastName+"," + this.Gender.ToString()+"," + this.DOB.ToString();
        }
    }
}
