using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV2.Exceptions
{
    //user defined exception
    internal class FirstNameException : ApplicationException
    {

        public FirstNameException(string message) : base(message)
        {

        }

    }
}
