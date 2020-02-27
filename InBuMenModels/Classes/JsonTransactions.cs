using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Newtonsoft.Json;

namespace InBuMenModels.Classes
{
    public class TransactionsGroup
    {
        public Transaction[] Property1 { get; set; }
    }

    public class Transaction
    {
        [JsonProperty("sku")]
        public string Sku { get; set; }
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

}
