using InBuMenModels.Classes;

namespace WebApiInBuMen.Services.Reading
{
    public interface IRateApiReader
    {
        JsonRateGroup ReadRates();
    }
}