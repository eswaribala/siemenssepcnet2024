using BankingAppV4.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV4
{
    internal class LambdaDemo
    {
        public static void Main()
        {

            //Lambda Expression

             GenerateTransactions().Where(x => x.TransactionDate > new DateTime(2014, 1, 1))                
                .ToList().ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x)));
            Console.WriteLine("Count Filtered Data....");

            Console.WriteLine($"Total Count={GenerateTransactions()
                .Count(x => x.TransactionDate > new DateTime(2014, 1, 1))}");

            Console.WriteLine("Sort by Sort Method Approach....");
            List<Transaction> test = GenerateTransactions().Where(x => x.TransactionDate > 
            new DateTime(2014, 1, 1)).ToList();
            test.Sort((x,y)=>x.TransactionDate.CompareTo(y.TransactionDate));
            test.ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x)));

            //alternative
            Console.WriteLine("Sort by Order By Approach....");
            GenerateTransactions().Where(x => x.TransactionDate > new DateTime(2014, 1, 1))
                .OrderBy(x => x.TransactionDate)
                .ToList().ForEach(x => Console.WriteLine(JsonConvert.SerializeObject(x)));

            Console.ReadKey();

        }

        static List<Transaction> GenerateTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            for(int i = 0; i < 100; i++)
            {
                transactions.Add(new Transaction
                {
                    TransactionNo = Faker.RandomNumber.Next(100, 10000),
                    TransactionDate = Faker.Identification.DateOfBirth(),
                    Amount = Faker.RandomNumber.Next(10000, 1000000)

                }) ;
            }
            return transactions;

        }


    }
}
