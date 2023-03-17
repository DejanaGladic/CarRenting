using RentingCar.Interfaces;

namespace RentingCar.Domain
{
    public class Vehicle: IVehicle
    {
        public char Offer { get; set; }
        public decimal Price { get; set; }
    }
}
