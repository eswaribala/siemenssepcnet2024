
using BankingAppV2.Exceptions;
using BankingAppV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV2
{
    internal class ExceptionDemo
    {
        public static void Main()
        {
            //test first name is in alphabets and 
            //no of characters must be more than 5
            Individual individual = null;
            string Pattern = "[A-Za-z]{5,}";
            string PasswordPattern = "[A-Za-z@0-9]{5,8}";

            try
            {

                string firstName = Faker.Name.First();
                string password = Faker.Identification.UkPassportNumber();

                if (!Regex.IsMatch(firstName, Pattern)) {

                    throw new FirstNameException("First Name should be in alphabets and Minimun 5 Chars");
                }
                 
                else if((password.Length <5) || (password.Length>8)) {
                    throw new PasswordLengthException("Password Length must be 5 or more ");
                }

                else if(!Regex.IsMatch(password, PasswordPattern)) {

                    throw new PasswordTypeMisMatchException("Password Type Not Matching");
                }
                else
                {

                    individual = new Individual(Faker.RandomNumber.Next(100, 10000),
                         new FullName(firstName, Faker.Name.Middle(), Faker.Name.Last()),
                         new Address[] { new Address(Faker.RandomNumber.Next(1,1000).ToString(),
                     Faker.Address.StreetName(), Faker.Address.City(), Faker.Address.CaProvince())
                         },
                          Faker.Phone.Number(), Faker.Internet.Email(),
                          password, Gender.MALE,
                          Faker.Identification.DateOfBirth()
                          );
                    Console.WriteLine(individual);

                }



               

            }
          
            catch (FirstNameException exception)
            {
                Console.WriteLine( exception.Message );

            }
            catch (PasswordLengthException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (PasswordTypeMisMatchException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


            Console.ReadKey();
          



        }
    }
}
