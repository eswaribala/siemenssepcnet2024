using BankingAppV3.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3
{
    internal class IEnumerableDemo
    {
        public static void Main()
        {
            //heterogeneous
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Parameswari");
            arrayList.Add(true);
            arrayList.Add(0.67F);
            arrayList.Add(new Transaction()
            {
                TransactionNo = Faker.RandomNumber.Next(1000, 100000),
                Salary = Faker.RandomNumber.Next(100000, 1000000),
                TransactionDate = DateTime.Now,
            });

             IEnumerator enumerator= arrayList.GetEnumerator();
            //method 1
            Console.WriteLine("By Enumerator...");
              while (enumerator.MoveNext())
              {
                var obj = enumerator.Current;                
                if (obj.GetType().ToString().Equals ("BankingAppV3.Models.Transaction"))
                {
                    Console.WriteLine(JsonConvert.SerializeObject(obj));
                }else
                  Console.WriteLine(obj);
              }
            //method 2
            Console.WriteLine("By ForEach...");
            foreach (var obj in arrayList)
                {
                if (obj.GetType().ToString().Equals("BankingAppV3.Models.Transaction"))
                {
                    Console.WriteLine(JsonConvert.SerializeObject(obj));
                }else
                   Console.WriteLine(obj);
                }

            Console.ReadKey();
             
             

         

        }

    }
}
