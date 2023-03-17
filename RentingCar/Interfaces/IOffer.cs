namespace RentingCar.Interfaces
{
    public interface IOffer: ICalculatePrice
    {
        decimal CalculatedPrice { get; set; }
    }
}