using BankingAppV3.DAL;
using BankingAppV3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3
{
    internal class ListSortDemo
    {

        public static void Main()
        {
           List<Customer> customers =CustomerDAL.GenerateCustomers(100);

            customers.Sort(new CustomerSorter());

            foreach (Customer customer in customers)
                Console.WriteLine(JsonConvert.SerializeObject(customer));

            Console.ReadKey();

        }
    }
}
