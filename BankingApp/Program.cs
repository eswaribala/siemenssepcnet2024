// See https://aka.ms/new-console-template for more information
#nullable disable
using System;

//csc /out:BankingApp.exe /main:BankingApp program.cs
///
/// Developed By Parameswari Ettiappan
///


namespace BankingApp
{
    class BankingApp
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Started understanding c#12 using .net core 8");
            //show command line arguments
            foreach (string arg in args) { 
              Console.WriteLine($"{arg}");
            }

            //show otps
            Console.WriteLine("Generated OTPs.....");
            foreach (int otp in DataTypeDemo.GetOTPs())
                Console.WriteLine(otp);
            Console.WriteLine($"Reversed number={DataTypeDemo
                .ReverseGivenNo(new Random().Next(10000))}");

            //compute income tax
            Console.WriteLine("Enter Gender");
            Gender gender=(Gender)Enum.Parse(typeof(Gender),Console.ReadLine());
            Console.WriteLine("Enter Income");
            long income=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"{DataTypeDemo.ComputeIncomeTax(gender, income)}");


            main();
            //Verbatim prefixing with @ avoids escape sequence
            string path = @"c:\test\test1.csv
            krwguirwitgiurgtiugrigt";
            Console.WriteLine($"Path of the CSV File={path}");
            //Static Method call
            DataTypeDemo.DataTypeMain(); 

            Console.ReadKey();
            return 0;
        }
        static int main()
        {
            Console.WriteLine("Invoke main from entry point");
            Console.ReadKey();
            return 0;
        }
    }
}
/*
//csc /out:BankingAppV1.exe /main:BankingAppV1 program.cs
class BankingAppV1
{
    static int Main()
    {
        Console.WriteLine("Started understanding c#12 using .net core 8 from V1");
        
        main();
        Console.ReadKey();
        return 0;
    }
    static int main()
    {
        Console.WriteLine("Invoke main from entry point");
        Console.ReadKey();
        return 0;
    }
}
*/