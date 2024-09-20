using BankingAppV4.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV4
{
    internal class InterThreadCommunication
    {
        static void Main()
        {
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>(10);
            BlockingCollection<int> receivedBlockingCollection = null;
            //Signalling for Inter Thread Communication
            using (ManualResetEvent manualResetEvent = new ManualResetEvent(false))
            {
                Thread thread = new Thread(() =>
                {
                    receivedBlockingCollection= Producer.GenerateData(blockingCollection);

                    try
                    {
                        //It sends the notification for the waiting thread
                        manualResetEvent.Set();
                    }
                    catch (ObjectDisposedException exception)
                    {
                        Console.WriteLine(exception);
                    }

                });
                thread.Start();
                //Waiting Thread
                if(manualResetEvent.WaitOne(5000))
                {
                    Consumer.ConsumesData(receivedBlockingCollection);

                }


            }


        }
    }
}
