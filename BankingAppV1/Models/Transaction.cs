using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV1.Models
{
    internal class Transaction:IDisposable
    {
        static int count = 0;

       
        //private constructor -- Singleton object
        private Transaction()
        {
            count++;
           
        }

        public static Transaction CreateInstance()
        {
            if (count < 1)
                return new Transaction();
            else
                throw new Exception("Singleton object maximum one, cannot create more than that");
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            //close the connections -file,network or db connection
            //cannot call destructor
            //GC automatically calls
            Console.WriteLine("Removing the object");
        }


        //create Destructor
        ~Transaction()
        {
            //close the connections -file,network or db connection
            //cannot call destructor
            //GC automatically calls
            Console.WriteLine("Removing the object");

        }


    }
}
