using InBuMenModels.Classes;

namespace InBuMenWebApi.Services.Factory
{
    public interface ITransactionFactory
    {
        ITransaction SaveTransaction(IJsonTransaction t);
    }
}