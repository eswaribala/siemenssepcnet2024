using BankingAppV3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingAppV3
{
    internal class ConcurrentDictionaryDemo
    {
        static ConcurrentDictionary<long, Transaction> concurrentDictionary = 
            new ConcurrentDictionary<long, Transaction>();

        public static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(AddData))
            {
              Name="Thread1"
            };
            Thread thread2 = new Thread(new ThreadStart(AddDataV1))
            {
                Name = "Thread2"
            };
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            foreach(KeyValuePair<long,Transaction> keyValuePair in concurrentDictionary)
            {

                Console.WriteLine(keyValuePair.Key.ToString() + "," +
                   JsonConvert.SerializeObject(keyValuePair.Value));
            }
            Console.ReadKey();
        }

        static void AddData()
        {
            for (int i = 0; i < 50; i++)
            {
                concurrentDictionary.TryAdd(i,
                    new Transaction()
                    {
                        TransactionNo = Faker.RandomNumber.Next(0, 100000),
                        Salary = Faker.RandomNumber.Next(10000, 10000000),
                        TransactionDate = Faker.Identification.DateOfBirth()
                    });
            }
        }
        static void AddDataV1()
        {
            for (int i = 0; i < 50; i++)
            {
                concurrentDictionary.TryAdd(i,
                    new Transaction()
                    {
                        TransactionNo = Faker.RandomNumber.Next(0, 100000),
                        Salary = Faker.RandomNumber.Next(10000, 10000000),
                        TransactionDate = Faker.Identification.DateOfBirth()
                    });
            }
        }
    }
}
