using BankingAppV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV4
{
    internal class TransactioFileDemo
    {

        public static void Main()
        {
          FileStream fileStream= new FileStream("F:\\Local disk\\CSharpSiemensDotnetSep2024\\BankingAppV4" +
              "\\BankingAppV4\\Transaction.csv",FileMode.Append,FileAccess.Write);
          StreamWriter streamWriter= new StreamWriter(fileStream);
           
          LambdaDemo.GenerateTransactions().ForEach(x => streamWriter.WriteLine(x.TransactionNo + "," +
                x.Amount + "," + x.TransactionDate.ToShortDateString()+"\n"));
            streamWriter.Close();
            Console.ReadKey();
         }
    }
}
