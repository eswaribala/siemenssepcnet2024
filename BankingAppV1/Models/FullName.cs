using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV1.Models
{
    internal class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName {  get; set; }

        public FullName() { 
        }
        public FullName(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
    }
}
