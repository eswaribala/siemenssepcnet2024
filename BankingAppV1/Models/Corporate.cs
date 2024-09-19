using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV1.Models
{
    enum CompanyType { PUBLIC,PRIVATE,GOVT,NGO}
    internal class Corporate : Customer
    {

        static Corporate()
        {
            Console.WriteLine("Derived Class (Corporate) Static Constructor");
        }
        public Corporate()
        {
            Console.WriteLine("Derived Class (Corporate) Default Constructor");
        }
        public Corporate(CompanyType companyType)
        {
            Console.WriteLine("Derived Class (Corporate) Parameterized Constructor");
            CompanyType = companyType;
        }

        public Corporate(long accountNo, FullName fullName, Address[] addresses, 
            string contactNo, string email, string password,CompanyType companyType) 
            : base(accountNo, fullName, addresses, contactNo, email, password)
        {
            this.CompanyType= companyType;
        }

        public CompanyType CompanyType { get; set; }
    }
}
