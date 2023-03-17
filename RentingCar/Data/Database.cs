using RentingCar.Domain;

namespace RentingCar.Data
{
    public class Database
    {
        public IEnumerable<Car> getAllCars = new List<Car>
        {
            new Car { Make ="Audi", Model = "A3", Year="2006", Offer='s',Price=2500 },
            new Car { Make ="Audi", Model = "A6", Year="2020", Offer='p',Price=25000 },
            new Car { Make ="BMW", Model = "589", Year="2023", Offer='p',Price=250000 }
        };
    }
}
