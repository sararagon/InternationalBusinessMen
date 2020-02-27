using System.Collections.Generic;

namespace InBuMenModels.Interfaces
{
    public interface IJsonRateGroup
    {
        List<IJsonRate> Rates { get; set; }
    }
}