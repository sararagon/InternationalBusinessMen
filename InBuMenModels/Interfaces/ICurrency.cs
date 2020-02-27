namespace InBuMenModels.Interfaces
{
    public interface ICurrency
    {
        int Id { get; set; }
        string CurrencyName { get; set; }
        int Amount { get; set; }
    }
}
