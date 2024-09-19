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
    internal class DictionaryDemo
    {
        public static void Main()
        {
            Dictionary<long, Transaction> Transactions = 
                TransactionDAL.GenerateTransactions(100);

            foreach(KeyValuePair<long,Transaction> keyValuePair in Transactions)
            {
                Console.WriteLine(keyValuePair.Key.ToString()+","+ 
                    JsonConvert.SerializeObject(keyValuePair.Value));
             }

            Console.ReadKey();

        }
    }
}
