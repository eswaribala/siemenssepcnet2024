using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace BankingAppV3
{
    class ThreadPoolDemo
    {
        static void Main()
        {
            // Start the task executing:
            var task = Task.Factory.StartNew<Task<string>>
            (() =>DownloadString("https://jsonplaceholder.typicode.com/users"));
           //if(task.IsCompleted)
           // {
                Console.WriteLine(task.GetAwaiter().GetResult());
           // }
            Console.ReadKey();
         
        }
         static async Task<string> DownloadString(string uri)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage httpResponse=await  httpClient.GetAsync(uri);
                return httpResponse.Content.ReadAsStringAsync().Result;
            }
           
        }
    }
}


 
