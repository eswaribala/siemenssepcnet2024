using BankingAppV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV2.DAL
{
    internal class IndividualSorter : IComparer<Individual>
    {
        public int Compare(Individual x, Individual y)
        {
            if(x.AccountNo > y.AccountNo) 
                return 1;
            else if(x.AccountNo < y.AccountNo) 
             return -1; 
            else
             return 0;
        }
    }
}
