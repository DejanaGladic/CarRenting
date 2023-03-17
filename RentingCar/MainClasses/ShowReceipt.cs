using RentingCar.Domain;
using RentingCar.Interfaces;

namespace RentingCar.MainClasses
{
    public class ShowReceipt
    {
        IReceipt receipt;
        public void ViewReceipt(IOffer offer)
        {
            Console.WriteLine("Card/Cash?");
            string ChoicePayment = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            switch (ChoicePayment.Trim().ToLower())
            {
                case "card":
                    FillEmailReceipt(offer.CalculatedPrice, "Card");
                    break;
                default:
                    EmailReceiptOrNot(offer);
                    break;
            }
            receipt.DisplayReceipt();           
        }

        public void EmailReceiptOrNot(IOffer offer)
        {
            Console.WriteLine("Email/NotEmail?");
            string ChoiceForEmail = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            if (ChoiceForEmail == "email")
            {
                FillEmailReceipt(offer.CalculatedPrice, "Cash");
            }
            else
            {
               FillReceipt(offer.CalculatedPrice, "Cash");
            }
        }

        private void FillReceipt(decimal calculatedPrice, string paymentMethod)
        {
            receipt = Factory.Factory.CreateReceipt("notEmail");
            receipt.CalculatedPrice = calculatedPrice;
            receipt.MethodOfPayment = paymentMethod;
        }

        public void FillEmailReceipt(decimal calculatedPrice, string paymentMethod)
        {
            receipt = Factory.Factory.CreateReceipt("email");
            receipt.CalculatedPrice = calculatedPrice;
            receipt.MethodOfPayment = paymentMethod;
            ((EmailReceipt)receipt).EmailAddress = "pp@gmail.com";
        }

    }
}
