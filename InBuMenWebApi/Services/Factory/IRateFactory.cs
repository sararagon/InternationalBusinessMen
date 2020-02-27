using InBuMenModels.Classes;
using InBuMenModels.Interfaces;

namespace InBuMenWebApi.Services.Factory
{
    public interface IRateFactory
    {
        IRate SaveRate(IJsonRate r);
    }
}