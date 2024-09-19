using BankingAppV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3.DAL
{
    internal class CustomerSorter : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            if(x.AccountNo>y.AccountNo)
                return -1;
            else if(x.AccountNo < y.AccountNo)
                return 1;
            else return 0;
        }
    }
}
