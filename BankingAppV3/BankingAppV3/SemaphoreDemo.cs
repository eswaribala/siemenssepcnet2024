using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3
{
    internal class SemaphoreDemo
    {
        static Semaphore semaphore=new Semaphore(2,2);
        public static void Main()
        {
            //Multi Threading 
            //10 threads getting created
            for(int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(DbConnectionPool));
                thread.Name = "Thread" + i;
                thread.Start();
            }

            Console.ReadKey();
        }

        static void DbConnectionPool()
        {
            Console.WriteLine("Thread tries to enter critical section" 
                + Thread.CurrentThread.Name);
            try
            {
                Console.WriteLine("Thread successfully entered critical section"
              + Thread.CurrentThread.Name);
                Thread.Sleep(2000);
                semaphore.WaitOne();
                Console.WriteLine("Thread exited critical section"
              + Thread.CurrentThread.Name);
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.Message}");
            }
            finally
            {
                semaphore.Release();
                Console.WriteLine("Semaphore Released from"
              + Thread.CurrentThread.Name);
            }

        }

    }
}
