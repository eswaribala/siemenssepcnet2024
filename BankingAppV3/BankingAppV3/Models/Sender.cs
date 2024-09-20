using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3.Models
{
    internal class Sender
    {
        public BlockingCollection<int> GenerateNumber(BlockingCollection<int> blockingCollection)
        {
            
            Thread.Sleep(1000);
            for(int i = 0; i < blockingCollection.BoundedCapacity; i++)
            {
                Console.WriteLine($"Producer produces Random Number {i}");
                blockingCollection.TryAdd(Faker.RandomNumber.Next(1, 1000));
            }



            return blockingCollection;
        }
    }
}
