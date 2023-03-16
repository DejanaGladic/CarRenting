using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace RentingCar.Domain
{
    public class Offer: CalculatePrice
    {
        public virtual decimal CalculatePrice(Vehicle vehicle)
        {
            return vehicle.Price;
        }
    }
}
