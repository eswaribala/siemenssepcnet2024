using BankingAppV3.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3
{
    internal class InterThreadCommunication
    {
        static BlockingCollection<int> randomNumbers = null;
        static void Main(string[] args)
        {
            Sender _sender = new Sender();
            Receiver _receiver = new Receiver();

            using (ManualResetEvent waitHandle = new ManualResetEvent(false))
            {
                // have to initialize this variable, otherwise the compiler complains when it is used later
                

                Thread thread1 = new Thread(new ThreadStart(() =>
                {
                    randomNumbers = _sender.GenerateNumber(new BlockingCollection<int>(boundedCapacity: 5));

                    try
                    {
                        // now that we have the random number, signal the wait handle
                        waitHandle.Set();
                    }
                    catch (ObjectDisposedException)
                    {
                        // this exception will be thrown if the timeout elapses on the call to waitHandle.WaitOne
                    }
                }));

                // begin receiving the random number
                thread1.Start();

                // wait for the random number
                if (waitHandle.WaitOne(/*optionally pass in a timeout value*/))
                {
                    _receiver.TakeRandomNumber(randomNumbers);
                }
                else
                {
                    // signal was never received
                    // Note, this code will only execute if a timeout value is specified
                    System.Console.WriteLine("Timeout");
                }
            }

            Console.ReadKey();
        }
    }
}
