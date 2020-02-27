namespace InBuMenModels.Classes
{
    public interface IRate
    {
        string FromCurrency { get; set; }
        string ToCurrency { get; set; }
        int Value { get; set; }
    }
}