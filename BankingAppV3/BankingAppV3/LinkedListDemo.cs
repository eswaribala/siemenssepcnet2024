using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV3
{
    internal class LinkedListDemo
    {
        public static void Main()
        {
            LinkedList<string> linkedList=new LinkedList<string>();

            for(int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    linkedList.AddLast(Faker.RandomNumber.Next(0, 100).ToString());
                else
                    linkedList.AddFirst(Faker.RandomNumber.Next(0, 100).ToString());
            }

            foreach(string data in linkedList)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
