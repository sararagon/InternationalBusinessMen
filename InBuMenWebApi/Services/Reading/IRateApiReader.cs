using System.Collections;
using InBuMenModels.Classes;

namespace InBuMenWebApi.Services.Reading
{
    public interface IRateApiReader
    {
        JsonRateGroup ReadRates();
    }
}