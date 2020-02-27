using System;
using System.Collections.Generic;
using System.Text;
using InBuMenModels.Interfaces;

namespace InBuMenModels.Classes
{
    public class JsonRateGroup : IJsonRateGroup
    {
        public List<IJsonRate> Rates { get; set; }
    }
}
