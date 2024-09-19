using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV2.Models
{
    internal class Address
    {
        public string DoorNo {  get; set; }
        public string StreetName {  get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public Address()
        {
        }

        public Address(string doorNo, string streetName, string city, string state)
        {
            DoorNo = doorNo;
            StreetName = streetName;
            City = city;
            State = state;
        }
    }
}
