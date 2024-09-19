using EcommerceApp.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    internal class AnonymousMethodDemo
    {
        public static void Main()
        {
            //Anonymous method delegate
            //step 2
            //Instantiated Delegate
            ReverseNameDelegate reverseNameDelegate =
                delegate(string[] names){

                    string AggregatedName=string.Empty;
                    //reversing the array
                    
                    foreach (string name in names)
                        {
                        char[] charArray = name.ToCharArray();
                        Array.Reverse(charArray);
                        AggregatedName += new string(charArray) + ",";

                        }
            return AggregatedName; 

            };

            //step3
            //invoke
          Console.WriteLine(reverseNameDelegate(MirrorDelegate.GetNames(50)));

            Console.ReadKey();

        }

    }
}
