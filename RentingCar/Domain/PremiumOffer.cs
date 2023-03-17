using RentingCar.Interfaces;

namespace RentingCar.Domain
{
    public class PremiumOffer: Offer
    {
        public override void CalculatePrice(IVehicle vehicle)
        {
            CalculatedPrice = vehicle.Price + (vehicle.Price * 15) / 100;
        }
    }
}
