using BankingAppV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV2
{
    internal class PartialClassDemo
    {
        public static void Main()
        {
            Account account = new Account();
            account.RunningTotal = 100000;
            account.DOP = new DateTime(2024, 2, 1);
            Console.WriteLine(account.RunningTotal.ToString()
                +","+account.DOP.ToString());
            Console.ReadKey();
            

        }
    }
}
