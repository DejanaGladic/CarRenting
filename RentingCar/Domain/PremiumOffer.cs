namespace RentingCar.Domain
{
    public class PremiumOffer: Offer
    {
        public override void CalculatePrice(Vehicle vehicle)
        {
            CalculatedPrice = vehicle.Price + (vehicle.Price * 15) / 100;
        }
    }
}
