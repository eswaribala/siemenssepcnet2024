using EcommerceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Delegates
{
    //step 1
    internal delegate Vehicle BikeDelegate(string brand);
    internal class VehicleDelegate
    { 
        public Vehicle M1000(string brand)
        {
            return new Vehicle()
            {
                Brand = brand,
                Mileage="5",
                Cost=4900000,
                EnginePower="1000cc",
                ModelName="M1000",
                Type="Racing"   


            };
        }
        public Vehicle R1250(string brand)
        {
            return new Vehicle()
            {
                Brand = brand,
                Mileage = "5",
                Cost = 2495000,
                EnginePower = "1000cc",
                ModelName = "R1250",
                Type = "Touring"


            };
        }

        public Vehicle G310R(string brand)
        {
            return new Vehicle()
            {
                Brand = brand,
                Mileage = "5",
                Cost = 290000,
                EnginePower = "1000cc",
                ModelName = "G130R",
                Type = "OffRoad"


            };
        }

    }
}
