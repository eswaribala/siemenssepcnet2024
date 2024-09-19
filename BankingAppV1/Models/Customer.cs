using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV1.Models
{
    internal class Customer
    {
        //static constructor
        static Customer()
        {
            Console.WriteLine("Base class Static Constructor...");
        }

        //default constructor
        public Customer()
        {
            Console.WriteLine("Base class Default Constructor...");
        }

        //parameterized constructor

        public Customer(long accountNo, FullName fullName, Address[] addresses, string contactNo, string email, string password)
        {
            Console.WriteLine("Base class Parameterized Constructor...");
            AccountNo = accountNo;
            FullName = fullName;
            Addresses = addresses;
            ContactNo = contactNo;
            Email = email;
            Password = password;
        }





        //properties
        //Mutators and Accessors
        protected long AccountNo {  get;  }

        protected FullName FullName { get;}

        protected Address[] Addresses { get; set; }

        protected string ContactNo {  get; set; }

        protected string Email { get; set; }

        protected string Password { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
