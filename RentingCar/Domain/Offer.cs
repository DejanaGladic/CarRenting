using RentingCar.Interfaces;

namespace RentingCar.Domain
{
    public class Offer: ICalculatePrice
    {
        public decimal CalculatedPrice { get; set; }
        public virtual void CalculatePrice(Vehicle vehicle)
        {
            CalculatedPrice=vehicle.Price;
        }
    }
}
