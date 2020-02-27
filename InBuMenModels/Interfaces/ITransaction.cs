using InBuMenModels.Classes;

namespace InBuMenModels.Interfaces
{
    public interface ITransaction
    {
        int Id { get; set; }
        string Sku { get; set; }
        Currency Value { get; set; }
    }
}