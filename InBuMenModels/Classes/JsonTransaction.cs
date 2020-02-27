using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using InBuMenModels.Interfaces;
using Newtonsoft.Json;

namespace InBuMenModels.Classes
{
    public class JsonTransaction : IJsonTransaction
    {
        [JsonProperty("sku")]
        public string Sku { get; set; }
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

}
