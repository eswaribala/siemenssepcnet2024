using EcommerceApp.Delegates;
using EcommerceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    internal class MulticastDelegate
    {

        public static void Main()
        {
            ParcelDelegate parcelDelegate = new ParcelDelegate();
            //step2 instantiating delegate
            DeliveryDelegate deliveryDelegate = 
                new DeliveryDelegate(parcelDelegate.InternationalDelivery);
            deliveryDelegate += new DeliveryDelegate(parcelDelegate.DomesticDelivery);
            Parcel parcel = new Parcel()
            {
                Distance=3000,
                Height=3,
                Weight=4,
                Width=3,
                IsSpeed=true              

            };
            //invoke the delegate
            //step 3
            foreach(DeliveryDelegate deliveryDelegateInstance in 
                deliveryDelegate.GetInvocationList())
            {
               Console.WriteLine ($"Parcel Cost={deliveryDelegateInstance(parcel)}");
            }

        }
    }
}
