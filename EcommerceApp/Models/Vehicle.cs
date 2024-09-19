using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace EcommerceApp.Models
{
    internal class Vehicle
    {
        public string Brand {  get; set; }
        public string ModelName { get; set; }
        public string EnginePower {  get; set; }

        public string Mileage { get; set; }
        public string Type { get; set; }

        public long Cost { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
