using System.Collections.Generic;
using InBuMenModels.Interfaces;

namespace InBuMenModels.Classes
{
    public interface IJsonRateGroup
    {
        List<IJsonRate> Rates { get; set; }
    }
}