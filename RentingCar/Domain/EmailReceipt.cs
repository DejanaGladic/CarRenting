namespace RentingCar.Domain
{
    public class EmailReceipt: Receipt
    {
        public string EmailAddress { get; set; }
        public override void DisplayReceipt()
        {
            Console.WriteLine("Calculated price is: {0}", CalculatedPrice);
            SendEmail();
        }
        public void SendEmail()
        {
            Console.WriteLine("Sending email to address: {0}...", EmailAddress);
        }
    }
}
