using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV2.Exceptions
{
    internal class PasswordTypeMisMatchException:ApplicationException
    {
        public PasswordTypeMisMatchException(string message):base(message) { 
        }  
    }
}
