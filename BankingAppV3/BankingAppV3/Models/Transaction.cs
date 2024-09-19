using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3.Models
{
    //step1

    internal delegate void SalaryCreditedDelegate(long TransactionNo, long Salary);
    internal class Transaction
    {
        //step2

        public event SalaryCreditedDelegate SalaryCreditedEvent;

        public long TransactionNo {  get; set; }
        public DateTime TransactionDate { get; set; }

        public long Salary { get; set; }

        //step 3
        //Raise Event
        public void RaiseEvent(long TransactionNo, long Salary)
        {
            SalaryCreditedEvent(TransactionNo, Salary);
        }

        //step 4
        //invoke event
        public void DepositSalary(long TransactionNo, long Salary)
        {
            this.TransactionNo= TransactionNo;
            this.TransactionDate = DateTime.Now;
            this.Salary = Salary;

            Console.WriteLine("Salary Credited.....");

            Console.WriteLine(JsonConvert.SerializeObject(this));
        }

    }
}
