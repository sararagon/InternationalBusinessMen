namespace InBuMenModels.Interfaces
{
    public interface IRate
    {
        int Id { get; set; }
        string FromCurrency { get; set; }
        string ToCurrency { get; set; }
        int Value { get; set; }
    }
}