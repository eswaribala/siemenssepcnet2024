using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV4
{
    internal class ThreadPoolDemo
    {
        public static void Main()
        {
            Task<int> task = null;
            for(int i = 0; i < 50; i++)
            {
                task = Task.Factory.StartNew(GetOTP);
                task.Wait();
                if (task.IsCompleted)
                {
                    Console.WriteLine($"Task {i} Generated OTP={task.GetAwaiter().GetResult()}");
                }
            }
            
            Console.ReadKey();
        }

        static int GetOTP()
        {
            return Faker.RandomNumber.Next(1000, 9999);
        }
    }
}
