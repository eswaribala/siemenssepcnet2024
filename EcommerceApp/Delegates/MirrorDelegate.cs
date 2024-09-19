using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Delegates
{
    //step1
    //defined the delegate
    internal delegate string ReverseNameDelegate(string[] names);
    internal class MirrorDelegate
    {
        public static string[] GetNames(int size)
        {
            string[] names = new string[size];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Faker.Name.First();
            }
            return names;
        }
    }

   
}
