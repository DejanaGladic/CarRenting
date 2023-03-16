using RentingCar.Data;
using RentingCar.Domain;

Console.WriteLine("Pick the car");

CarList carList = new CarList();

foreach (var value in carList.GetAllCars)
{
    Console.WriteLine("{0} {1} {2}, offer:{3}, price:{4}",
        value.Make,value.Model, value.Year, value.Offer, value.Price);
}
//kao korisnik je izabrao, ne znam kako preko konzole i bez baze - test

Vehicle pickedVehicle = new Car { Make = "Audi", Model = "A3", Year = "2006", Offer = 'p', Price = 2500 };
Offer offer;

switch (pickedVehicle.Offer)
{
    case 's':
        offer = new StandardOffer();
        break;
    default:
        offer = new PremiumOffer();
        break;
}

decimal calculatedPrice = offer.CalculatePrice(pickedVehicle);
Console.WriteLine(calculatedPrice);