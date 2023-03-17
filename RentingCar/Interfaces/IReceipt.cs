namespace RentingCar.Interfaces
{
    public interface IReceipt: IDisplayReceipt
    {
        decimal CalculatedPrice { get; set; }
        string MethodOfPayment { get; set; }
    }
}