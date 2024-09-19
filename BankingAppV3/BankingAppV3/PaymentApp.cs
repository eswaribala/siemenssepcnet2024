using BankingAppV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingAppV3
{
    internal class PaymentApp
    {
        public static void Main()
        {

            Transaction transaction=new Transaction();

            //publish event

            transaction.SalaryCreditedEvent += transaction.DepositSalary;

            //Subscription

            transaction.RaiseEvent(Faker.RandomNumber.Next(100000, 1000000000),
                Faker.RandomNumber.Next(50000,20000000));



        }

    }
}
