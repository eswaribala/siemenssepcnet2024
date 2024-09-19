using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3.Models
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
        public long AccountNo { get; set; }

        public FullName FullName { get; set; }

        public Address[] Addresses { get; set; }

        public string ContactNo {  get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

      

    }
}
