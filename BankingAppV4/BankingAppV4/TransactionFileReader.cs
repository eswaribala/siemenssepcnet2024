using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV4
{
    internal class TransactionFileReader
    {
        public static void Main()
        {
            string Path = @"F:\Local disk\CSharpSiemensDotnetSep2024\BankingAppV4\BankingAppV4\Transaction.csv";
            FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string Line=string.Empty;
            string[] data = null;
            List<long> transactions=new List<long>();
            while ((Line = streamReader.ReadLine())!=null) {
                data = Line.Split(",");
                if (data.Length == 3)              
                    transactions.Add(Convert.ToInt64(data[1]));
                                       
            }            
            Console.WriteLine($"Total Transaction={transactions.Sum(x => x)}");
            Console.WriteLine($"Average Transaction={transactions.Average(x=>x)}");
            Console.WriteLine($"Minimum Transaction={transactions.Min(x=>x)}");
            Console.WriteLine($"Maximum Transaction={transactions.Max(x => x)}");
            Console.WriteLine($"No of Transaction={transactions.Count()}");
            streamReader.Close();
            Console.ReadKey();
          
        }

    }
}
