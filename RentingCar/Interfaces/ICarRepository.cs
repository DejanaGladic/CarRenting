using RentingCar.Domain;

namespace RentingCar.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
    }
}
