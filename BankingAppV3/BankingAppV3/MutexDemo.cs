using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3
{
    internal class MutexDemo
    {
        static int balance=10000;

        static Mutex Mutex = new Mutex();
        public static void Main()
        {
            //MultiThread
            ParameterizedThreadStart parameterizedThreadStart = new 
                ParameterizedThreadStart(Withdraw);

            for(int i = 0; i < 5; i++) {
                Thread thread = new Thread(parameterizedThreadStart)
                {
                    Name = "Thread" + i,
                    IsBackground = false,
                    Priority = ThreadPriority.Normal
                };
                thread.Start(Faker.RandomNumber.Next(1000,5000));
            }

            Console.ReadKey();
        }

        

        static void Withdraw(object amount)
        {
            Console.WriteLine($"Thread enters critical Section"+Thread.CurrentThread.Name);
            int WithdrawAmount=Convert.ToInt32(amount);    
            Mutex.WaitOne();
            if (WithdrawAmount < balance)
            {

                Console.WriteLine("You have sufficient Balance");
                Thread.Sleep(1000);
                balance-= WithdrawAmount;
                Console.WriteLine("Transaction Completed and Balance="+ balance);               
            }else
                Console.WriteLine("You don't have sufficient Balance");

            Mutex.ReleaseMutex();
            Console.WriteLine($"Thread exiting critical Section" + Thread.CurrentThread.Name);

        }
    }
}
