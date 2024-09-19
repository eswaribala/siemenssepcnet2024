using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankingAppV3
{
    internal class StackDemo
    {
        public static void Main()
        {
            //LIFO
            Stack<string> stack=new Stack<string>();

            for(int i=0; i < 10; i++)
            {
               
                stack.Push(Convert.ToString(i, 2));
               
            }
            string PoppedValue=string.Empty;
           
            while (stack.Count>0)
            {
                PoppedValue = stack.Pop();

                Console.WriteLine(PoppedValue);
            }

            Console.ReadKey();
        }


       
    }
}
