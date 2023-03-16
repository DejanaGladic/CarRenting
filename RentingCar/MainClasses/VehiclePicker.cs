using RentingCar.Data;
using RentingCar.Domain;

namespace RentingCar.MainClasses
{
    public class VehiclePicker
    {
        public Vehicle PickTheVehicle()
        {
            Console.WriteLine("Pick the car");

            CarList carList = new CarList();
            foreach (var value in carList.GetAllCars)
            {
                Console.WriteLine("{0} {1} {2}, offer:{3}, price:{4}",
                    value.Make, value.Model, value.Year, value.Offer, value.Price);
            }

            //kao korisnik je izabrao, ne znam kako preko konzole i bez baze
            Vehicle pickedVehicle = new Car { Make = "Audi", Model = "A3", Year = "2006", Offer = 'p', Price = 2500 };

            Console.WriteLine("------------");
            Console.WriteLine("Picked car is:");
            Car pickedCar = (Car)pickedVehicle;
            Console.WriteLine("{0} {1} {2}, offer:{3}, price:{4}",
                    pickedCar.Make, pickedCar.Model, pickedCar.Year, pickedCar.Offer, pickedCar.Price);

            return pickedVehicle;
        }
    }
}
