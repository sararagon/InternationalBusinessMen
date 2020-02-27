using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Specification
{
    public interface ICurrencySpecification
    {
        bool IsSatisfiedBy(string c);
    }
}