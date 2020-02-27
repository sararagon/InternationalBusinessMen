namespace InBuMenModels.Classes
{
    public interface ITransaction
    {
        string Sku { get; set; }
        Currency Value { get; set; }
    }
}