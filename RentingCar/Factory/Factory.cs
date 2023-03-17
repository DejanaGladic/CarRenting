using RentingCar.Interfaces;
using RentingCar.Repository;
using RentingCar.Domain;


namespace RentingCar.Factory
{
    public static class Factory
    {
        public static ICarRepository CreateCarRepository() {
            return new CarRepository();
        }

        public static IVehicle CreateVehicle(string vehicleType)
        {
            return new Car();
        }

        public static IOffer CreateOffer(char offerType)
        {
            if (offerType == 'p')
                return new PremiumOffer();
            return new Offer();          
        }

        public static IReceipt CreateReceipt(string receiptType)
        {
            if (receiptType == "email")
                return new EmailReceipt();
            return new Receipt();
        }
    }
}
