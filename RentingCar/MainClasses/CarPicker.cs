using RentingCar.Domain;
using RentingCar.Interfaces;

namespace RentingCar.MainClasses
{
    public class CarPicker
    {
        ICarRepository _carRepository;
        IVehicle _car;
        public CarPicker(ICarRepository carRepository, IVehicle car)
        {
            _carRepository = carRepository;
            _car = car;
        }

        public IVehicle PickCar()
        {
            Console.WriteLine("Pick the car");
            foreach (var value in _carRepository.GetAllCars())
            {
                Console.WriteLine("{0} {1} {2}, offer:{3}, price:{4}",
                    value.Make, value.Model, value.Year, value.Offer, value.Price);
            }

            //kao korisnik je izabrao, ne znam kako preko konzole i bez baze
            Car pickedCar = (Car)_car;
            pickedCar.Make = "Audi";
            pickedCar.Model = "A3";
            pickedCar.Year = "2006";
            pickedCar.Offer = 'p';
            pickedCar.Price = 2500;
            Console.WriteLine("------------");
            Console.WriteLine("Picked car is:");

            Console.WriteLine("{0} {1} {2}, offer:{3}, price:{4}",
                    pickedCar.Make, pickedCar.Model, pickedCar.Year, pickedCar.Offer, pickedCar.Price);

            return pickedCar;
        }

        public IVehicle GetCar() { 
            return _car;
        }
    }
}
