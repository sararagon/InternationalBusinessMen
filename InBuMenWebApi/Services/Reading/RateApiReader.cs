using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using InBuMenModels.Classes;
using Newtonsoft.Json;
using static System.Web.Caching.Cache;

namespace WebApiInBuMen.Services.Reading
{
    public class RateApiReader : IRateApiReader
    {
        public JsonRateGroup ReadRates()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://quiet-stone-2094.herokuapp.com/rates.json").Result;
                string contentResult = response.Content.ReadAsStringAsync().Result;
                {
                    return JsonConvert.DeserializeObject<JsonRateGroup>(contentResult);
                }
            }
        }
    }
}