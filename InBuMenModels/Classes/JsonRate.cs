using System;
using System.Collections.Generic;
using System.Text;
using InBuMenModels.Interfaces;
using Newtonsoft.Json;

namespace InBuMenModels.Classes
{
    public class JsonRate : IJsonRate
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
        [JsonProperty("rate")]
        public string Rate { get; set; }
    }

}
