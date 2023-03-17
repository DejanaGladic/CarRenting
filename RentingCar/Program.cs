using RentingCar.Factory;
using RentingCar.Interfaces;
using RentingCar.MainClasses;


ICarRepository carRepository = Factory.CreateCarRepository();
IVehicle car = Factory.CreateVehicle("car");
CarPicker carPicker = new CarPicker(carRepository, car);
carPicker.PickCar();

IOffer offer = Factory.CreateOffer('s');
OfferCreation offerCreation = new OfferCreation(offer, carPicker.GetCar());
offerCreation.CreateOffer();

IReceipt receipt = Factory.CreateReceipt("classic");
ShowReceipt showReceipt = new ShowReceipt(receipt, offerCreation.GetOffer());
showReceipt.ViewReceipt();













