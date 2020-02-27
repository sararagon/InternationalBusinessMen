using System.Collections.Generic;

namespace InBuMenModels.Classes
{
    internal interface IJsonRateGroup
    {
        List<IJsonRate> Rates { get; set; }
    }
}