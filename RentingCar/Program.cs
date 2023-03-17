using RentingCar.Factory;
using RentingCar.Interfaces;
using RentingCar.MainClasses;


ICarRepository _carRepository = Factory.CreateCarRepository();
VehiclePicker vehiclePicker = new VehiclePicker(_carRepository);
IVehicle pickedCar = vehiclePicker.PickCar();

OfferCreation offerCreation = new OfferCreation();
IOffer createdOffer = offerCreation.CreateOffer(pickedCar);

ShowReceipt showReceipt = new ShowReceipt();
showReceipt.ViewReceipt(createdOffer);













