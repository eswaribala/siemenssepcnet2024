using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace EcommerceApp.Models
{
    internal class Parcel
    {
        public double Weight {  get; set; }
        public double Width {  get; set; }
        public double Height { get; set; }

        public bool IsSpeed {  get; set; }

        public double Distance {  get; set; }

        public string Cost { get; set; } 


    }
}
