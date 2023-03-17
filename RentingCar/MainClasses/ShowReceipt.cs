using RentingCar.Domain;
using RentingCar.Interfaces;

namespace RentingCar.MainClasses
{
    public class ShowReceipt
    {
        IReceipt _receipt;
        private IOffer _offer;

        public ShowReceipt(IReceipt receipt, IOffer offer)
        {
            this._receipt = receipt;
            this._offer = offer;
        }

        public void ViewReceipt()
        {
            Console.WriteLine("Card/Cash?");
            string ChoicePayment = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            switch (ChoicePayment.Trim().ToLower())
            {
                case "card":
                    FillEmailReceipt(_offer.CalculatedPrice, "Card");
                    break;
                default:
                    EmailReceiptOrNot();
                    break;
            }
            _receipt.DisplayReceipt();           
        }

        public void EmailReceiptOrNot()
        {
            Console.WriteLine("Email/Not Email?");
            string ChoiceForEmail = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            if (ChoiceForEmail == "email")
            {
                FillEmailReceipt(_offer.CalculatedPrice, "Cash");
            }
            else
            {
               FillReceipt(_offer.CalculatedPrice, "Cash");
            }
        }

        private void FillReceipt(decimal calculatedPrice, string paymentMethod)
        {
            _receipt = Factory.Factory.CreateReceipt("notEmail");
            _receipt.CalculatedPrice = calculatedPrice;
            _receipt.MethodOfPayment = paymentMethod;
        }

        public void FillEmailReceipt(decimal calculatedPrice, string paymentMethod)
        {
            _receipt = Factory.Factory.CreateReceipt("email");
            _receipt.CalculatedPrice = calculatedPrice;
            _receipt.MethodOfPayment = paymentMethod;
            ((EmailReceipt)_receipt).EmailAddress = "pp@gmail.com";
        }

    }
}
