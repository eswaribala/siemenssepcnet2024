using BankingAppV3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingAppV3.DAL
{
    internal class TransactionDAL
    {

        public static Dictionary<long,Transaction> GenerateTransactions(int count)
        {
            Dictionary<long,Transaction> TransactionList=new 
                Dictionary<long, Transaction> (); 

            for(int i = 0; i < count; i++)
            {
                TransactionList.Add(Faker.RandomNumber.Next(1000, 100000),
                    new Transaction()
                    {
                        TransactionNo=Faker.RandomNumber.Next(0,100000),
                        Salary=Faker.RandomNumber.Next(10000,10000000),
                        TransactionDate=Faker.Identification.DateOfBirth()
                    });
            }

            return TransactionList;
        }
    }
}
