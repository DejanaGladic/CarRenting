using RentingCar.Data;
using RentingCar.Domain;
using RentingCar.Interfaces;

namespace RentingCar.Repository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetAllCars()
        {
            Database database = new Database();
            return database.getAllCars;
        }
    }
}
