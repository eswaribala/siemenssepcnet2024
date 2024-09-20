using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV4.Models
{
    
    internal class Transaction
    {        

        public long TransactionNo {  get; set; }
        public DateTime TransactionDate { get; set; }
        public long Amount { get; set; }        

    }
}
