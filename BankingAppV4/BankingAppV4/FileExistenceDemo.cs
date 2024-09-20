using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV4
{
    internal class FileExistenceDemo
    {
        public static void Main(string[] args)
        {
            //Pass Directory path
            DirectoryInfo directoryInfo = new DirectoryInfo(args[0]);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            string Target = "LambdaDemo.cs";
            foreach (FileInfo fileInfo in fileInfos)
            {
                if(fileInfo.Name.Equals(Target))
                   Console.WriteLine(fileInfo.Name);
            }

            Console.ReadKey();

        }
    }
}
