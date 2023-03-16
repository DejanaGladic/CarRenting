using RentingCar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingCar.MainClasses
{
    public class OfferCreation
    {
        public Offer CreateOffer(Vehicle pickedVehicle)
        {
            Offer offer;
            switch (pickedVehicle.Offer)
            {
                case 's':
                    offer = new StandardOffer();
                    break;
                default:
                    offer = new PremiumOffer();
                    break;
            }

            offer.CalculatePrice(pickedVehicle);

            return offer;
        }
    }
}
