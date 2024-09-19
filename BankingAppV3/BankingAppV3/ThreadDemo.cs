using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3
{
    internal class ThreadDemo
    {
        static readonly object namedobject=new object();
        public static void Main()
        {
           // Console.WriteLine(Thread.CurrentThread.Name);
            //Thread start is delegate
            ParameterizedThreadStart parameterizedThreadStart =
                new ParameterizedThreadStart(PrintName);
           //Multi Threading
            Thread thread1 = new Thread(parameterizedThreadStart);
            thread1.Name = "Thread1";
            Thread thread2 = new Thread(parameterizedThreadStart);
            thread2.Name = "Thread2";
            thread1.Start(Faker.Name.First());
            thread2.Start(Faker.Name.First());
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Job Completed....");
            Console.ReadKey();            
        }
        static void PrintName(object name)
        {                    
            char[] chars=name.ToString().ToCharArray();
            
            //synchrnonization
            lock (namedobject)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                foreach (char c in chars)
                {

                    Console.Write(c);

                    Thread.Sleep(1000);
                }
                Console.WriteLine("\n");
            }

           
        }
    }
}
