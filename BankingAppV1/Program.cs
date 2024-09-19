// See https://aka.ms/new-console-template for more information
using BankingAppV1.DAL;
using BankingAppV1.Models;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
#nullable disable
namespace BankingAppV1
{
    class App
    {
        static void Main(string[] args)
        {

            Transaction transaction = Transaction.CreateInstance();

           // Transaction transaction1 = Transaction.CreateInstance();

          
            //foreach (string arg in args)
            //{
            //    Console.WriteLine(arg);
            //}

            ////call by value
            //string name = "Parameswari";
            //UpdateName(name);
            //Console.WriteLine($"After Update Name={name}");

            ////call by reference
            //DateTime dateTime = DateTime.Now;
            //UpdateDOB(ref dateTime);
            //Console.WriteLine($"After Update DOB={dateTime}");
            ////call by reference with out return
            //string ugQualification = string.Empty;
            //string pgQualification = string.Empty;
            //long employeeNo = Convert.ToInt64(new Random().Next(1000, 1000000));
            //UpdateQualification(ref employeeNo,
            //    out ugQualification, out pgQualification);
            //Console.WriteLine($"After Update " +
            //    $"Qualification={ugQualification},{pgQualification}");

            ////params
            //string skills= string.Empty;
            ////employee 1
            //UpdateSkillSet(ref employeeNo, out skills, "C", "C++", "Java", "Python");
            //Console.WriteLine($"After Update " +
            //    $"Skill Set={employeeNo},{skills}");
            ////employee 2
            //employeeNo = Convert.ToInt64(new Random().Next(1000, 1000000));
            //UpdateSkillSet(ref employeeNo, out skills, "Java", "Python");
            //Console.WriteLine($"After Update " +
            //    $"Skill Set={employeeNo},{skills}");
            ////employee 3
            //employeeNo = Convert.ToInt64(new Random().Next(1000, 1000000));
            //UpdateSkillSet(ref employeeNo, out skills);
            //Console.WriteLine($"After Update " +
            //    $"Skill Set={employeeNo},{skills}");


            ////generate customers

            //foreach(Individual individual in IndividualDAL.GenerateIndividuals(25))
            //{
            //    Console.WriteLine(individual);
            //}
            

            Console.ReadKey();

        }

        //call by value
        static void UpdateName(string name)
        {
            if (name != null)
                name = name.Substring(1, 5);
            else
                name = name.Substring(1, 3);
        }


        //call by reference

        static void UpdateDOB(ref DateTime dateTime)
        {
            dateTime = new DateTime(1980, 2, 2);
        }

        //return multiple values from method

        static void UpdateQualification(ref long employeeNo, out string ugQualificaion,
            out string pgQualification)
        {
            if (employeeNo > 0)
            {
                ugQualificaion = "B.E";
                pgQualification = "M.E";
            }
            else
            {
                ugQualificaion = string.Empty;
                pgQualification = string.Empty;
            }


        }


        //params
        static void UpdateSkillSet(ref long employeeNo,  out string skills, 
            params string[] skillSet)
        {
            skills= string.Empty;
            if (employeeNo > 0)
            {
                foreach (string skill in skillSet)
                {
                    
                    skills=skills+","+skill;
                }

            }
        }


    }
}
