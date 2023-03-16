using RentingCar.Domain;

namespace RentingCar.MainClasses
{
    public class ReceiptDisplay
    {
        Receipt receipt;
        public void DisplayReceipt(Offer offer)
        {
            Console.WriteLine("Card/Cash?");
            string ChoicePayment = Console.ReadLine();
            switch (ChoicePayment)
            {
                case "Card":
                    EmailReceipt(offer, "Card");
                    break;
                default:
                    EmailReceiptOrNot(offer);
                    break;
            }
            receipt.DisplayReceipt();           
        }

        void EmailReceiptOrNot(Offer offer)
        {
            Console.WriteLine("Email/NotEmail?");
            string ChoiceForEmail = Console.ReadLine();
            if (ChoiceForEmail == "Email")
            {
                EmailReceipt(offer, "Cash");
            }
            else
            {
                receipt = new Receipt
                {
                    CalculatedPrice = offer.CalculatedPrice,
                    MethodOfPayment = "Cash"
                };
            }
        }

        void EmailReceipt(Offer offer, string PaymentMethod)
        {
            receipt = new EmailReceipt
            {
                CalculatedPrice = offer.CalculatedPrice,
                EmailAddress = "pp@gmail.com",
                MethodOfPayment = PaymentMethod
            };
        }
    }
}
