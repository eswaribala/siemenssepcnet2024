using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV4.Models
{
    internal class Producer
    {
       public static BlockingCollection<int> GenerateData(BlockingCollection<int> 
           blockingCollection)
        {
            BlockingCollection<int> blockingCollectionInstance= new 
                BlockingCollection<int>(blockingCollection.BoundedCapacity);
          

            for(int i = 0; i < blockingCollection.BoundedCapacity; i++) {

                int number = Faker.RandomNumber.Next(1, 100000);
                Console.WriteLine($"Producing Data {number}"); 

                blockingCollectionInstance.Add(number);

            }

            Thread.Sleep(2000);

            return blockingCollectionInstance;


        }

    }
}
