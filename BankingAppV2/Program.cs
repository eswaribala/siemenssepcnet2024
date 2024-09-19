// See https://aka.ms/new-console-template for more information
using BankingAppV2.DAL;
using BankingAppV2.Models;

namespace BankingAppV2
{
    class App
    {
        static void Main(string[] args)
        {
            Individual[] individuals = IndividualDAL.GenerateIndividuals(100);
            //sorting
            Array.Sort(individuals);

            foreach(Individual individual in individuals)
            {
                Console.WriteLine(individual);
               
            }

            Console.ReadKey();

        }
    }
}
