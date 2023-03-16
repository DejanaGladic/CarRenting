using RentingCar.Interfaces;

namespace RentingCar.Domain
{
    public class Receipt: IDisplayReceipt
    {
        public decimal CalculatedPrice { get; set; }
        public string MethodOfPayment { get; set; }

        public virtual void DisplayReceipt()
        {
            Console.WriteLine("Calculated price is: {0}",CalculatedPrice);
        }
    }
}
