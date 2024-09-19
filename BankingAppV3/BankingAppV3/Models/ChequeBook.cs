using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BankingAppV3.Models
{
    //step1

    internal delegate void OrderDelegate(int OrderNo);
    internal class ChequeBook
    {
        //step2
        public event OrderDelegate OrderDelegateEvent;
        public long OrderNo {  get; set; }
        public int Count {  get; set; }
        public Customer Customer { get; set; }

        //step 3
        public void RaiseEvent(int OrderNo)
        {
            OrderDelegateEvent(OrderNo);
        }
        
        //step 4
        //invoke Event
        public void OrderDispatched(int OrderNo)
        {
            this.OrderNo = OrderNo;
            Console.WriteLine("Order Dispatched.... Details Follow");
            Console.WriteLine(JsonConvert.SerializeObject(this));
        }


    }
}
