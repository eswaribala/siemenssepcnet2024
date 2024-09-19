using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingApp
{
    enum Gender { MALE,FEMALE,TRANSGENDER}
    enum CompanyType { GOVT,PUBLIC,PRIVATE,NGO}
    internal class DataTypeDemo
    {
      public static void DataTypeMain()
        {
            //Local Variable
            sbyte accountNo = 125;
            Console.WriteLine($"Account No={accountNo}");
            int location = 0xFF;
            Console.WriteLine("Location's Value={location}");
            //declare enum variable
            Console.WriteLine("Enter Gender");
            string genderValue=Console.ReadLine();
            Gender gender=(Gender) Enum.Parse(typeof(Gender),genderValue);
            Console.WriteLine($"Gender={gender}");

            //currency representation/formatter
            double salary = 72576.956;
            Console.WriteLine("Salary={0:C}", salary);


        }

        //Array Demo
        public static int[] GetOTPs()
        {
            //step 1 declare array
            int[] OTPSArray=new int[25];
            //step 2 assign vakues
            for (int i = 0; i < OTPSArray.Length; i++)
                //step 3 generate random values
                OTPSArray[i] = new Random().Next(1000, 9999);

            //sort the array using selection sort
            var arrayLength = OTPSArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (OTPSArray[j] < OTPSArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = OTPSArray[smallestVal];
                OTPSArray[smallestVal] = OTPSArray[i];
                OTPSArray[i] = tempVar;
            }
            //step 4 return  the array
            return OTPSArray;


        }


        public static int ReverseGivenNo(int number) 
        {
            Console.WriteLine($"Actual No={number}");
            //use while loop
            int reminder=0, quotient = 0;
            String data = "";
            
            while(number > 0)
            {
                reminder = number % 10;
                quotient = number / 10;
                data = data + reminder;
                number = quotient;
            }

            return Convert.ToInt32(data);

        }

        public static double ComputeIncomeTax(Gender gender, long income)
        {
            double computedTax = 0.0;


            switch (gender)
            {
                case Gender.MALE:
                    if (income <= 180000)
                    {
                        computedTax = 0.0;
                    }
                    else if ((income >= 180001) && (income <= 500000))
                        computedTax = computedTax + income * .10;
                    else if ((income >= 500001) && (income <= 800000))
                        computedTax = computedTax + income * .20;
                    else
                        computedTax = computedTax + income * .30;
                    break;
                 case Gender.FEMALE:

                    if (income <= 190000)
                    {
                        computedTax = 0.0;
                    }
                    else if ((income >= 190001) && (income <= 500000))
                        computedTax = computedTax + income * .10;
                    else if ((income >= 500001) && (income <= 800000))
                        computedTax = computedTax + income * .20;
                    else
                        computedTax = computedTax + income * .30;

                    break;

            }


            /*

            if(gender == Gender.MALE)
            {
                if (income <= 180000)
                {
                    computedTax = 0.0;
                }
                else if ((income >= 180001) && (income <= 500000))
                    computedTax = computedTax + income * .10;
                else if ((income >= 500001) && (income <= 800000))
                    computedTax = computedTax + income * .20;
                else
                    computedTax = computedTax + income * .30;

            }
            else if (  gender == Gender.FEMALE) { 
                
                    if (income <= 190000)
                    {
                        computedTax = 0.0;
                    }
                    else if ((income >= 190001) && (income <= 500000))
                        computedTax = computedTax + income * .10;
                    else if ((income >= 500001) && (income <= 800000))
                        computedTax = computedTax + income * .20;
                    else
                        computedTax = computedTax + income * .30;

                }else
                    {
                computedTax = 0.0;
                    }
            */
            return computedTax;

        }


    }
}
