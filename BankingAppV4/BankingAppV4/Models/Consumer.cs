using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV4.Models
{
    internal class Consumer
    {

        public static void ConsumesData(BlockingCollection<int> blockingCollection)
        {

            foreach (var item in blockingCollection)
            {
                Console.WriteLine($"Data Received from Producer->{item}");
            }

        }
    }
}
