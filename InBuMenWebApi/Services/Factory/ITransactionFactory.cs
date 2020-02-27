using InBuMenModels.Classes;
using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Factory
{
    public interface ITransactionFactory
    {
        ITransaction SaveTransaction(IJsonTransaction t);
    }
}