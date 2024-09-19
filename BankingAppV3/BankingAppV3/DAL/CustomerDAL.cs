using BankingAppV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3.DAL
{
    internal class CustomerDAL
    {

        public static List<Customer> GenerateCustomers(int count)
        {
            List<Customer> CustomersList = new List<Customer>();

            for(int i=0;i<count; i++)
            {
                CustomersList.Add(new Customer()
                {
                    AccountNo = Faker.RandomNumber.Next(100, 10000),
                    FullName = new FullName()
                    {
                        FirstName = Faker.Name.First(),
                        MiddleName = Faker.Name.Middle(),
                        LastName = Faker.Name.Last()
                    },
                    Addresses = new Address[] { new Address(Faker.RandomNumber.Next(1,1000).ToString(),
                     Faker.Address.StreetName(), Faker.Address.City(), Faker.Address.CaProvince())
                     },
                    ContactNo = Faker.Phone.Number(),
                    Email = Faker.Internet.Email(),
                    Password = Faker.Identification.UkPassportNumber()

                });

            }
            
            return CustomersList;

        }
    }
}
