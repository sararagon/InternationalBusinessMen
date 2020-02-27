using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using InBuMenModels.Classes;
using Newtonsoft.Json;

namespace InBuMenWebApi.Services.Reading
{
    public class TransactionApiReader
    {
        public JsonTransactionGroup ReadRates()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://quiet-stone-2094.herokuapp.com/transactions.json").Result;
                string contentResult = response.Content.ReadAsStringAsync().Result;
                {
                    return JsonConvert.DeserializeObject<JsonTransactionGroup>(contentResult);
                }
            }
        }
    }
}