using System.Collections.Generic;

namespace InBuMenModels.Classes
{
    public interface IJsonRateGroup
    {
        List<IJsonRate> Rates { get; set; }
    }
}