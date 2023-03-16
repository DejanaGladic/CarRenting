using RentingCar.Domain;
using RentingCar.MainClasses;


VehiclePicker VehiclePicker = new VehiclePicker();
Vehicle PickedVehicle = VehiclePicker.PickTheVehicle();

OfferCreation OfferCreation = new OfferCreation();
Offer CreatedOffer = OfferCreation.CreateOffer(PickedVehicle);

ReceiptDisplay ReceiptDisplay = new ReceiptDisplay();
ReceiptDisplay.DisplayReceipt(CreatedOffer);













