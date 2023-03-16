namespace RentingCar.Domain
{
    public class StandardOffer: Offer
    {
        public override decimal CalculatePrice(Vehicle vehicle)
        {
            return vehicle.Price + (vehicle.Price * 20) / 100;
        }
    }
}
