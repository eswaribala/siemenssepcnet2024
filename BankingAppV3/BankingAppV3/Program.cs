// See https://aka.ms/new-console-template for more information
using BankingAppV3.Models;

namespace BankingAppV3
{
    class App
    {
        public static void Main()
        {
            //Event Publisher

            ChequeBook chequeBook = new ChequeBook()
            {
                Count = 1,
                Customer = new Customer()
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

                }

            };


            //intantiate the Event

            chequeBook.OrderDelegateEvent+= chequeBook.OrderDispatched;

            //Subscription

            chequeBook.RaiseEvent(Faker.RandomNumber.Next(1000, 9999));



        }
    }
}
