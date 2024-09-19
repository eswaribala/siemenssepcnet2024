using BankingAppV2.DAL;
using BankingAppV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV2
{
    internal class BankingAppSortDemo
    {
        public static void Main()
        {
            Individual[] individuals = IndividualDAL.GenerateIndividuals(100);
            IndividualSorter individualSorter = new IndividualSorter();
            //sorting
            Array.Sort(individuals,individualSorter);

            foreach (Individual individual in individuals)
            {
                Console.WriteLine(individual);

            }

            Console.ReadKey();
        }
    }
}
