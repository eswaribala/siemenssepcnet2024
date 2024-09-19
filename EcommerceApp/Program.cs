// See https://aka.ms/new-console-template for more information
using EcommerceApp.Delegates;
using static EcommerceApp.Delegates.VehicleDelegate;

namespace EcommerceApp
{
    class App
    {
        public static void Main()
        {
            VehicleDelegate vehicleDelegate = new VehicleDelegate();
            //instantiate the delegate
            //Bike Delegate points method
            //step 2 we connect delegate to methods

            BikeDelegate[] bikeDelegates=new BikeDelegate[3];
            bikeDelegates[0] = new BikeDelegate(vehicleDelegate.M1000);
            bikeDelegates[1] = new BikeDelegate(vehicleDelegate.R1250);
            bikeDelegates[2]=new BikeDelegate(vehicleDelegate.G310R);

            foreach(BikeDelegate bikeDelegate in bikeDelegates)
            {
                //step 3 invoke bike Delegate
                Console.WriteLine(bikeDelegate("BMW").ToString());
            }


        }
    }
}
