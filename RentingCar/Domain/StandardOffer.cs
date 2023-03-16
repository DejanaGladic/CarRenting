namespace RentingCar.Domain
{
    public class StandardOffer: Offer
    {
        public override void CalculatePrice(Vehicle vehicle)
        {
            CalculatedPrice = vehicle.Price + (vehicle.Price * 20) / 100;
        }
    }
}
