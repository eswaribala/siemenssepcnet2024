using BankingAppV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV1.DAL
{
    internal class IndividualDAL
    {

       public static Individual[] GenerateIndividuals(int individualCount)
        {
            //declare customer array
            Individual[] individuals = new Individual[individualCount];
            Gender gender = Gender.MALE;
            for(int i = 0; i < individualCount; i++)
            {
                if (i % 2 == 0)
                    gender = Gender.FEMALE;
                else
                    gender = Gender.MALE;


                individuals[i] = new Individual(Faker.RandomNumber.Next(100,10000),
                     new FullName(Faker.Name.First(),Faker.Name.Middle(),Faker.Name.Last()),
                     new Address[] { new Address(Faker.RandomNumber.Next(1,1000).ToString(),
                     Faker.Address.StreetName(), Faker.Address.City(), Faker.Address.CaProvince())                    
                     },
                      Faker.Phone.Number(), Faker.Internet.Email(), 
                      Faker.Identification.UkPassportNumber(),gender,
                      Faker.Identification.DateOfBirth()
                      
                    );
               
            }

            return individuals;

        }
         
    }
}
