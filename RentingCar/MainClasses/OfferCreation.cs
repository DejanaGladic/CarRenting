using RentingCar.Interfaces;

namespace RentingCar.MainClasses
{
    public class OfferCreation
    {
        IOffer _offer;
        IVehicle _vehicle;
        public OfferCreation(IOffer offer, IVehicle vehicle)
        {
            _offer = offer;
            _vehicle = vehicle;
        }

        public IOffer CreateOffer()
        {
            _offer = Factory.Factory.CreateOffer(_vehicle.Offer);
            _offer.CalculatePrice(_vehicle);

            return _offer;
        }

        public IOffer GetOffer()
        {
            return _offer;
        }
    }
}
