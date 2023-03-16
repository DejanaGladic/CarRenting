namespace RentingCar.Domain
{
    public class PremiumOffer: Offer
    {
        public override decimal CalculatePrice(Vehicle vehicle)
        {
            return vehicle.Price + (vehicle.Price * 15) / 100;
        }
    }
}
