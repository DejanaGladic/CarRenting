using RentingCar.Interfaces;

namespace RentingCar.Domain
{
    public class Offer:  IOffer
    {
        public decimal CalculatedPrice { get; set; }

        public virtual void CalculatePrice(IVehicle vehicle)
        {
            CalculatedPrice = vehicle.Price + (vehicle.Price * 20) / 100;
        }
    }
}
