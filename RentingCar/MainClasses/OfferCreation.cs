using RentingCar.Interfaces;

namespace RentingCar.MainClasses
{
    public class OfferCreation
    {
        public IOffer CreateOffer(IVehicle pickedVehicle)
        {
            IOffer offer;
            offer = Factory.Factory.CreateOffer(pickedVehicle.Offer);          
            offer.CalculatePrice(pickedVehicle);

            return offer;
        }
    }
}
