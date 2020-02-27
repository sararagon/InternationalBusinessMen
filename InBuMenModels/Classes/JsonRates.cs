using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace InBuMenModels.Classes
{
    public class RatesGroup
    {
        public Rates[] Property1 { get; set; }
    }

    public class Rates
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
        [JsonProperty("rate")]
        public string Rate { get; set; }
    }

}
