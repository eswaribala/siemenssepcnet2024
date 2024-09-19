using EcommerceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Delegates
{
    //step 1 define delegate
    internal delegate string DeliveryDelegate(Parcel parcel);
    internal class ParcelDelegate
    {

        public string InternationalDelivery(Parcel parcel)
        {
            if (parcel != null)
            {

                if ((parcel.Weight < 5) && (parcel.Distance < 5000)
                      && (parcel.Width < 5) && (parcel.Height < 5))
                {
                    parcel.Cost = "International Delivery" + 15000;
                    return parcel.Cost;
                }
                else if ((parcel.Weight < 5) && (parcel.Distance < 5000)
                      && (parcel.Width < 5) && (parcel.Height < 5) && parcel.IsSpeed)
                {
                    parcel.Cost = "International Delivery" + 30000;
                    return parcel.Cost;
                }
                else
                {
                    parcel.Cost = "International Delivery" + 45000;
                    return parcel.Cost;
                }


            }
            else
            {

                return "International Delivery" + 0;
            }
           

        }

        public string DomesticDelivery(Parcel parcel)
        {
            if (parcel != null)
            {

                if ((parcel.Weight < 5) && (parcel.Distance < 1000)
                      && (parcel.Width < 5) && (parcel.Height < 5))
                {
                    parcel.Cost = "Domestic Delivery" + 5000;
                    return parcel.Cost;
                }
                else if ((parcel.Weight < 5) && (parcel.Distance < 1000)
                    && (parcel.Width < 5) && (parcel.Height < 5) && parcel.IsSpeed)
                {
                    parcel.Cost = "Domestic Delivery" + 10000;
                    return parcel.Cost;
                }
                else
                {
                    parcel.Cost = "Domestic Delivery" + 16000;
                    return parcel.Cost;
                }


            }
            else
                return "Domestic Delivery" + 0;;
        }
    }
}
