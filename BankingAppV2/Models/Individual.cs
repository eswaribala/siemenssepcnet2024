using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV2.Models
{
    enum Gender { MALE,FEMALE,TRANSGENDER}
    //Multiple Inheritance Using Customer and IComparable
    internal class Individual:Customer,IComparable<Individual>
    {
        private static long Threshold;
        static Individual()
        {
            Threshold = 500000L;
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

        
        public int CompareTo(Individual other)
        {

            //return this.DOB.CompareTo(other.DOB);
            return 0;
        }

        public override long Deposit(long amount)
        {
            if (amount < Threshold)
            {
                Console.WriteLine("Transaction for Deposit Possible");
            }
            else
                throw new Exception("Exceeded Threshold");

            return amount;

        }

        public override string ToString()
        {
            return this.AccountNo + "," + this.FullName.FirstName +","+
                this.FullName.LastName+"," + this.Gender.ToString()+"," + this.DOB.ToString();
        }

        public override long Withdraw(long amount)
        {
            if (amount < Threshold)
            {
                Console.WriteLine("Transaction for Withdraw Possible");
            }
            else
                throw new Exception("Exceeded Threshold");

            return amount;

        }
    }
}
