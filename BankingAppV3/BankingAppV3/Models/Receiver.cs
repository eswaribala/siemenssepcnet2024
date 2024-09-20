using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3.Models
{
    internal class Receiver
    {
        public void TakeRandomNumber(BlockingCollection<int> randomNumbers)
        {
            // do something
          Console.WriteLine("Received random numbers");
            foreach (int number in randomNumbers)
            {
                Console.WriteLine($"Consumer consumes Random Number {number}");
            }
        }
    }
}
